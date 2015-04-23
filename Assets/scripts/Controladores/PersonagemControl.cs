using UnityEngine;
using System.Collections;
using System.Linq;

public class PersonagemControl : MonoBehaviour {
	
	/*
	 *  VARIAVEIS
	 */

	//movimentacao
	public Transform[] targets;
	public bool antiHorario;
	public Transform localFila;

	public enum Estado {caminhando, fila, comprando};
	public Estado estado;
	
	public NavMeshAgent agent;
	private int n;
	private Animator anim;
	private RaycastHit quadra;

	//compra
	private ArrayList sucosDisponiveis = new ArrayList();
	public string sucoDesejado;
	public string sucoFavorito;

	//indices
	public int satisfacao = 50; //%
	public int sede = 0; //random
	public int pressa = 0;
	public float sedeRate = 2; //quantos segundos demora pra subir 1% da sede
	public bool disponibilidadeSucoFavorito = false;
	private float currentSedeRate;

	private TendaControl tenda;

	//Huds
	public GameObject hudPersonagem;
	public GameObject hudPersonagemFala;
	public GameObject hudPersonagemPensamento;

	private GameObject localHudPensamento;

	//Texturas e acessorios
	public bool comSuco;

	public GameObject copo;
	public GameObject barba;
	public GameObject bigode;
	public GameObject oculos;
	public GameObject[] cabelos;

	public Color[] corCabelo;

	public Color randomCorCabelo;
	private float chanceBigode = 0.3f;
	private float chanceBarba = 0.3f;
	private float chanceOculos = 0.3f;

	public Renderer personagemRenderer;
	public Material[] personagemMaterial;

	//Timer Suco
	private float tempoSuco = 10;
	private float currentTempoSuco = 0;
	
	/*
	 *  Sistema
	 */

	void Start () {

		int randomMaterial = Random.Range(0, personagemMaterial.Length);
		int randomCabelo = Random.Range(0, cabelos.Length);
		
		personagemRenderer.material = personagemMaterial[randomMaterial];
		copo.SetActive(false);

		if(Random.value > chanceBigode)
			bigode.SetActive(false);
		if(Random.value > chanceBarba)
			barba.SetActive(false);
		if(Random.value > chanceOculos)
			oculos.SetActive(false);

		randomCorCabelo = corCabelo[Random.Range(0,corCabelo.Length)];
		barba.renderer.material.color = randomCorCabelo;
		bigode.renderer.material.color = randomCorCabelo;
		if (cabelos[randomCabelo] != null){
			cabelos[randomCabelo].SetActive(true);
			cabelos[randomCabelo].renderer.material.color = randomCorCabelo;
		}

		agent = GetComponent<NavMeshAgent>();
		anim = GetComponent<Animator>();
		pressa = (int)Random.Range(0,100);
		sede = (int)Random.Range(0,100);

		// Destino inicial randomico
		n = Random.Range(0,4);

		// Velocidade relativa a pressa
		GetComponent<NavMeshAgent>().speed = 0.4f + ((float)pressa / 100) * 0.7f;

		// Direcao randomica
		antiHorario = RandomBool();

		estado = Estado.caminhando;

		if(Physics.Raycast(transform.position, Vector3.down, out quadra, 1f)){
			for(int i = 0; i < 4; i++){
				targets[i] = quadra.collider.GetComponent<QuadraControl>().targets[i];
			}
		}

		//Sede 
		currentSedeRate = 0;

		//gera suco preferido
		string[] sucos = {"LARANJA", "LIMÃO", "PÊSSEGO", "TAMARINDO", "UVA"};
		int s = Random.Range(0, sucos.Length);
		this.sucoFavorito = sucos[s] as string;

		//pensamento

		localHudPensamento = Instantiate(hudPersonagemPensamento, transform.position, hudPersonagemPensamento.transform.rotation) as GameObject;
		localHudPensamento.GetComponent<PersonagemHudPensamentoControl>().personagemControl = GetComponent<PersonagemControl>();
	}
	
	void Update () {
	
		if(comSuco){
			currentTempoSuco += Time.deltaTime;
			if (currentTempoSuco > tempoSuco){
				comSuco = false;
				copo.SetActive(false);
				currentTempoSuco = 0;
			}
		}

		//Aumentando a sede
		currentSedeRate += Time.deltaTime;
		if (currentSedeRate >= sedeRate){
			if(sede < 100)
				sede++;
			currentSedeRate = 0;
		}

		anim.SetFloat("Speed", agent.velocity.magnitude);
		anim.SetBool("Suco", comSuco);
		if(estado == Estado.caminhando){
			// Movimentacao do personagem no cenario.
			agent.SetDestination(targets[n].position);
			if(Vector3.Distance(agent.destination, transform.position) < 0.5){
				if(antiHorario){
					if(n>0){
						n--;
					} else {
						n = targets.Length - 1 ;
					}
				} else {
					n++;
					if(n == targets.Length)
						n = 0;
				}
			}
		} else {
			agent.SetDestination(localFila.position);
			if(Vector3.Distance(agent.destination, transform.position) < 0.2){
				transform.rotation = Quaternion.Lerp(transform.rotation, localFila.rotation , Time.deltaTime * 4);
			}
		}

		//pensamento

		if(localHudPensamento.GetComponent<PersonagemHudPensamentoControl>().exibindoPensamento == true && GameManager.simulador.statusHud == false && GameManager.simulador.statusVenda == false){
			localHudPensamento.GetComponent<PersonagemHudPensamentoControl>().exibindoPensamento = false;

			//exibe dica
			Invoke("exibirBalaoPensamento", Random.Range(6,22));
		}

	}

	void OnTriggerEnter(Collider collider){

		this.ressetaSucosDisponiveis();		

		if(collider.tag == "Tenda" && estado == Estado.caminhando){
			tenda = collider.GetComponent<TendaControl>();
			if( GameManager.simulador.statusVenda && this.Probabilidade() && this.Preco() ){
				int quantidadeFila = collider.GetComponent<TendaControl>().quantidadeFila;

				if(quantidadeFila < collider.GetComponent<TendaControl>().filaLocais.Length){
					estado = Estado.fila;
					localFila = collider.GetComponent<TendaControl>().filaLocais[quantidadeFila];
					collider.GetComponent<TendaControl>().personagensFila[quantidadeFila] = gameObject;
					collider.GetComponent<TendaControl>().quantidadeFila++;

					//gera suco desejado
					int suco = Random.Range(0, sucosDisponiveis.Count);
					this.sucoDesejado = sucosDisponiveis[suco] as string;
					
					//this.exibirBalaoPedido();
				}
			}
		}

	} 

	void OnMouseDown () {
		//exibe hud personagem
		if(GameManager.simulador.statusVenda == false && GameManager.simulador.statusHud == false){
			GameObject localHudPersonagem = Instantiate(hudPersonagem, transform.position, hudPersonagem.transform.rotation) as GameObject;
			localHudPersonagem.GetComponent<PersonagemHudControl>().personagemControl = GetComponent<PersonagemControl>();
		}
	}

	/*
	 *  Game
	 */

	public void exibirBalaoPensamento(){
		localHudPensamento.GetComponent<PersonagemHudPensamentoControl>().exibir();
	}

	public void exibirBalaoPedido(){
		//balao do suco desejado
		GameObject localHudPersonagemFala = Instantiate(hudPersonagemFala, transform.position, hudPersonagemFala.transform.rotation) as GameObject;
		localHudPersonagemFala.GetComponent<PersonagemHudFalaControl>().personagemControl = GetComponent<PersonagemControl>();
		localHudPersonagemFala.GetComponent<PersonagemHudFalaControl>().exibeSucoDesejado (this.sucoDesejado);
	}

	public void exibirBalaoSatisfacao(string sentimento){
		//balao satisfacao
		GameObject localHudPersonagemFala = Instantiate(hudPersonagemFala, transform.position, hudPersonagemFala.transform.rotation) as GameObject;
		localHudPersonagemFala.GetComponent<PersonagemHudFalaControl>().personagemControl = GetComponent<PersonagemControl>();
		localHudPersonagemFala.GetComponent<PersonagemHudFalaControl>().exibeSentimento (sentimento);
	}

	private bool RandomBool(){
		return (Random.value > 0.5f);
	}

	private bool Probabilidade(){
		//verefica se tem suco favorito
		for(int i=0; i<sucosDisponiveis.Count; i++){
			if( (string) sucosDisponiveis[i] == sucoFavorito ){
				this.disponibilidadeSucoFavorito = true;

				break;
			}
		}

		//faz calculo da probabilidade de entrar na fila
		
		/*
		 * Pressa			20%
		 * Satisfação		30%
		 * Sede				25%
		 * Fruta Pref.		25%
		 */

		int quantidadeFila = tenda.quantidadeFila;
		float random = Random.value;
		float coeficente = (0.2f - (pressa/100 * 0.2f) + (0.2f -(2.5f * quantidadeFila/100))) + (satisfacao/100 * 0.3f) + (sede/100 * 0.25f);
		if (disponibilidadeSucoFavorito)
			coeficente += 0.25f;

		//Debug.Log ("Coeficiente: " + coeficente + "Random: " + random + "Suco: " + disponibilidadeSucoFavorito + " > " + disponibilidadeSucoFavorito);

		if (random < coeficente){
			return true; 
		} else {
			return false;
		}

	}

	private bool Preco(){
		//valor da fruta + copo + gelo + margem

		if( GameManager.simulador.getQtdLaranja() > 0 ){
			if( GameManager.simulador.prcSucoLaranja <= (6) ){ 
				return true;
			}
		}

		if( GameManager.simulador.getQtdLimao() > 0 ){
			if( GameManager.simulador.prcSucoLimao <= (8) ){
				return true;
			}
		}

		if( GameManager.simulador.getQtdPessego() > 0 ){
			if( GameManager.simulador.prcSucoPessego <= (10) ){
				return true;
			}
		}

		if( GameManager.simulador.getQtdTamarindo() > 0 ){
				if( GameManager.simulador.prcSucoTamarindo <= (24) ){
				return true;
			}
		}

		if( GameManager.simulador.getQtdUva() > 0 ){
			if( GameManager.simulador.prcSucoUva <= (12) ){
				return true;
			}
		}
		
		return false;
	}

	public void ressetaSucosDisponiveis(){
		
		//limpa array
		sucosDisponiveis.Clear();
		
		//popula a dita
		if(GameManager.simulador.getQtdLaranja() > 0){
			sucosDisponiveis.Insert(sucosDisponiveis.Count, "LARANJA");
		}
		
		if(GameManager.simulador.getQtdLimao() > 0){
			sucosDisponiveis.Insert(sucosDisponiveis.Count,"LIMÃO");
		}
		
		if(GameManager.simulador.getQtdPessego() > 0){
			sucosDisponiveis.Insert(sucosDisponiveis.Count,"PÊSSEGO");
		}
		
		if(GameManager.simulador.getQtdTamarindo() > 0){
			sucosDisponiveis.Insert(sucosDisponiveis.Count,"TAMARINDO");
		}
		
		if(GameManager.simulador.getQtdUva() > 0){
			sucosDisponiveis.Insert(sucosDisponiveis.Count,"UVA");
		}
	}

	public void exibirSuco(){
		copo.SetActive(true);
		comSuco = true;
	}
	
}
