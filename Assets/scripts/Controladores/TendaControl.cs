using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TendaControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

	private Vector3 posicaoAtual;
	private Quaternion rotacaoAtual;
	
	private GameObject cameraObject;
	private TendaHudControl hudControl;	
	private CameraControl cameraControl;

	private bool inTurno = false;

	public GameObject hud;	
	private bool exibirHud = false;

	public Transform[] filaLocais;
	public GameObject[] personagensFila;
	public int quantidadeFila = 0;

	//frutas obj
	public GameObject objTriturador;	
	private GameObject trituradorInstanciado;

	public GameObject objLaranja;
	private GameObject laranjaInstanciada;

	public GameObject objLimao;
	private GameObject limaoInstanciado;

	public GameObject objPessego;
	private GameObject pessegoInstanciado;

	public GameObject objTamarindo;
	private GameObject tamarindoInstanciado;

	public GameObject objUva;
	private GameObject uvaInstanciada;

	public GameObject objCopo;
	private GameObject copoInstanciado;

	public GameObject objGelo;	
	private GameObject geloInstanciado;

	private ProcessadorControl processador;

	//preparacao
	private bool GeloSelect = false;
	private bool CopoSelect = false;
	private bool FrutaSelect = false;

	private string SucoPreparado;

	//som
	public AudioClip endTurnAudio;
	public AudioClip erroSelecao;

	//controle de turno
	private bool estadoTurnoAtual = true;
	private bool fimSuprimentos = false;

	//pedido
	private bool exibiuPedido = false;

	/*
	 *  Sistema
	 */
	
	void Start () {
		cameraObject = GameObject.FindWithTag ("MainCamera");
		
		cameraControl = cameraObject.GetComponent<CameraControl> ();
		hudControl = this.hud.GetComponent<TendaHudControl>();
	}
	
	void Update () {
		if(exibirHud && cameraControl.lerpControl == false){	
			//exibe a hud
			hudControl.exibir();
			
			exibirHud = false;
		}

		//inicia simulacao
		if(GameManager.simulador.statusVenda == true && inTurno == false){	

			//turno
				this.estadoTurnoAtual = true;
				
			//camera
				this.posicaoAtual = cameraObject.transform.position;
				this.rotacaoAtual = Quaternion.Euler(cameraObject.transform.rotation.eulerAngles);
	
				cameraControl.setMovimentacao(false);
				cameraControl.fixarCamera(this.transform.position.x-0.2f, 0.70f, this.transform.position.z-0.80f, -15, -105, 0);

			//objestos
				float disObj = 0.11f;
				Vector3 posicaoObjs = new Vector3(this.transform.position.x-0.6f, this.transform.position.y+0.4f, this.transform.position.z + 0.05f);
	
				//triturador
				trituradorInstanciado = Instantiate( objTriturador, posicaoObjs, this.transform.rotation) as GameObject;
				processador = trituradorInstanciado.GetComponent<ProcessadorControl>();
		
				//frutas
				if(GameManager.simulador.getQtdLaranja() > 0){
					posicaoObjs.x += disObj;
					laranjaInstanciada = Instantiate( objLaranja, posicaoObjs, this.transform.rotation) as GameObject;
				} else {
					if(laranjaInstanciada != null){
						Destroy(laranjaInstanciada);
					}
				}
	
				if(GameManager.simulador.getQtdLimao() > 0){
					posicaoObjs.x += disObj;
					limaoInstanciado = Instantiate( objLimao, posicaoObjs, this.transform.rotation) as GameObject;
				} else {
					if(limaoInstanciado != null){
						Destroy(limaoInstanciado);
					}
				}
	
				if(GameManager.simulador.getQtdPessego() > 0){
					posicaoObjs.x += disObj;
					pessegoInstanciado = Instantiate( objPessego, posicaoObjs, this.transform.rotation) as GameObject;
				} else {
					if(pessegoInstanciado != null){
						Destroy(pessegoInstanciado);
					}
				}
	
				if(GameManager.simulador.getQtdTamarindo() > 0){
					posicaoObjs.x += disObj;
					tamarindoInstanciado = Instantiate( objTamarindo, posicaoObjs, this.transform.rotation) as GameObject;
				} else {
					if(tamarindoInstanciado != null){
						Destroy(tamarindoInstanciado);
					}
				}
	
				if(GameManager.simulador.getQtdUva() > 0){
					posicaoObjs.x += disObj;
					uvaInstanciada = Instantiate( objUva, posicaoObjs, this.transform.rotation) as GameObject;
				} else {
					if(uvaInstanciada != null){
						Destroy(uvaInstanciada);
					}
				}
	
				if(GameManager.simulador.getQtdCopo() > 0){
					posicaoObjs.x += disObj;
					copoInstanciado = Instantiate( objCopo, posicaoObjs, this.transform.rotation) as GameObject;
				} else {
					if(copoInstanciado != null){
						Destroy(copoInstanciado);
					}
				}
	
				if(GameManager.simulador.getQtdGelo() > 0){
					posicaoObjs.x += disObj;
					geloInstanciado = Instantiate( objGelo, posicaoObjs, this.transform.rotation) as GameObject;
				} else {
					if(geloInstanciado != null){
						Destroy(geloInstanciado);
					}
				}
		}
		
		//simulacao
		if(GameManager.simulador.statusVenda){
			//inicia turno
				GameManager.simulador.reproduzirTurno();

			//controle do turno
				if( this.fimSuprimentos && hudControl.avisoControl.estado){
					GameManager.simulador.encerarTurno();
					
					this.estadoTurnoAtual = false;
					this.fimSuprimentos = false;
					exibirHud = true;

					hudControl.avisoControl.estado = false;
				}
			
			//camera
				cameraControl.setMovimentacao(false);

				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit;
	
			//objetos
				GameManager.simulador.mouseType = "pointer";

				if(Physics.Raycast(ray,out hit))
				{
					//Debug.Log(hit.collider.gameObject.name);

					if (hit.collider.gameObject.name == "Laranja(Clone)") {
						GameManager.simulador.mouseType = "click";					
	
						if(Input.GetMouseButtonDown(0))
						{	
							this.selecionarItem("LARANJA");
						}
					}

					if (hit.collider.gameObject.name == "Limao(Clone)") {
						GameManager.simulador.mouseType = "click";

						if(Input.GetMouseButtonDown(0))
						{
							this.selecionarItem("LIMÃO");
						}
					}  

					if (hit.collider.gameObject.name == "Pessego(Clone)") {
						GameManager.simulador.mouseType = "click";

						if(Input.GetMouseButtonDown(0))
						{
							this.selecionarItem("PÊSSEGO");
						}
					} 

					if (hit.collider.gameObject.name == "Tamarindo(Clone)") {
						GameManager.simulador.mouseType = "click";

						if(Input.GetMouseButtonDown(0))
						{
							this.selecionarItem("TAMARINDO");
						}
					}

					if (hit.collider.gameObject.name == "Uva(Clone)") {
						GameManager.simulador.mouseType = "click";

						if(Input.GetMouseButtonDown(0))
						{
							this.selecionarItem("UVA");
						}
					} 

					if (hit.collider.gameObject.name == "CopoGelo(Clone)") {
						GameManager.simulador.mouseType = "click";
						
						if(Input.GetMouseButtonDown(0))
						{
							this.selecionarItem("GELO");
						}
					} 

					if (hit.collider.gameObject.name == "CopoSuco(Clone)") {
						GameManager.simulador.mouseType = "click";

						if(Input.GetMouseButtonDown(0))
						{
							this.selecionarItem("COPO");
						}
					} 

					if(hit.collider.gameObject.name == "ProcessadorSuco(Clone)") {
						//GameManager.simulador.mouseType = "click";

						if(Input.GetMouseButtonDown(0))
						{
							this.validaSuco();
						}
					} 

					//encerar turno
					if(hit.collider.gameObject.name == "btSair") {
						GameManager.simulador.mouseType = "click";

						if(Input.GetMouseButtonDown(0))
						{
							GameManager.simulador.encerarTurno();

							this.estadoTurnoAtual = false;
							exibirHud = true;
						}
					}
				}

				//remove frutas que acabaram
				if(GameManager.simulador.getQtdLaranja() == 0){
					if(laranjaInstanciada != null){
						Destroy(laranjaInstanciada);
					}
				}
				
				if(GameManager.simulador.getQtdLimao() == 0){
					if(limaoInstanciado != null){
						Destroy(limaoInstanciado);
					}
				}
				
				if(GameManager.simulador.getQtdPessego() == 0){
					if(pessegoInstanciado != null){
						Destroy(pessegoInstanciado);
					}
				}
				
				if(GameManager.simulador.getQtdTamarindo() == 0){
					if(tamarindoInstanciado != null){
						Destroy(tamarindoInstanciado);
					}
				}
				
				if(GameManager.simulador.getQtdUva() == 0){
					if(uvaInstanciada != null){
						Destroy(uvaInstanciada);
					}
				}
				
				if(GameManager.simulador.getQtdCopo() == 0){
					if(copoInstanciado != null){
						Destroy(copoInstanciado);
					}
				}
				
				if(GameManager.simulador.getQtdGelo() == 0){
					if(geloInstanciado != null){
						Destroy(geloInstanciado);
					}
				}

			//pedidos
			if(personagensFila[0] != null && exibiuPedido == false){
				personagensFila[0].GetComponent<PersonagemControl>().exibirBalaoPedido();
				exibiuPedido = true;
			}
				

			inTurno = true;
		}

		//fim simulacao
		if(GameManager.simulador.statusVenda == false && inTurno){
			//mouse
				GameManager.simulador.mouseType = "pointer";

			//som
				audio.clip = endTurnAudio;
				audio.Play ();			

			//camera
				//cameraControl.setMovimentacao(false);
				cameraControl.fixarCamera(this.posicaoAtual.x, this.posicaoAtual.y, this.posicaoAtual.z, this.rotacaoAtual.x+15, this.rotacaoAtual.y+105, this.rotacaoAtual.z);

			//objestos
				Destroy(trituradorInstanciado);

				if(laranjaInstanciada != null){
					Destroy(laranjaInstanciada);
				}

				if(limaoInstanciado != null){
					Destroy(limaoInstanciado);
				}
		
				if(pessegoInstanciado != null){
					Destroy(pessegoInstanciado);
				}
	
				if(tamarindoInstanciado != null){
					Destroy(tamarindoInstanciado);	
				}
	
				if(uvaInstanciada != null){
					Destroy(uvaInstanciada);	
				}
	
				if(geloInstanciado != null){
					Destroy(geloInstanciado);
				}

				if(copoInstanciado != null){
					Destroy(copoInstanciado);
				}

			//esvazia fila
				EsvaziarFila();
				

			this.inTurno = false;
			exibirHud = true;
		}

		//hud re-open
		if(GameManager.simulador.statusVenda == false && exibirHud && cameraControl.lerpControl == false){
			hudControl.exibir();
			hudControl.abrirPainel("resultados");

			GameManager.simulador.ressetarFluxoDeCaixa = true;
			
			exibirHud = false;
		}

		//checa fim do jogo
			if(GameManager.simulador.gameOver == true){
				hudControl.gameOverControl.exibir();
				hudControl.ocultar();
			}

			if(GameManager.simulador.gameWin == true){
				hudControl.gameWinControl.exibir();
				hudControl.ocultar();
			}
	}
	
	void FixedUpdate() {
		
	}
	
	void OnMouseOver () {

	}
	
	void OnMouseDown () {
		
		if( GameManager.simulador.getStatusHud() == false && cameraControl.lerpControl == false && GameManager.simulador.statusVenda == false ){
			//fixar camera no objeto
			cameraControl.travarCamera (this.transform.position.x, this.transform.position.y, this.transform.position.z);
			
			exibirHud = true;
		}
	}

	/*
	 *  Game
	 */

	public void EsvaziarFila(){
		exibiuPedido = false;

		for(int i = 0; i < (quantidadeFila); i++){
			if(estadoTurnoAtual == false){
				personagensFila[i].GetComponent<PersonagemControl>().satisfacao -= 10;
				personagensFila[i].GetComponent<PersonagemControl>().exibirBalaoSatisfacao("insatisfeito");
			}

			personagensFila[i].GetComponent<PersonagemControl>().estado = PersonagemControl.Estado.caminhando;

			personagensFila[i] = null;			
		}

		quantidadeFila = 0;
	}

	public void AndaFila(){
		if(personagensFila[0] != null){
			exibiuPedido = false;

			personagensFila[0].GetComponent<PersonagemControl>().estado = PersonagemControl.Estado.caminhando;
			personagensFila[0].GetComponent<PersonagemControl>().exibirSuco();
			quantidadeFila--;
			
			for(int i = 0; i < (quantidadeFila); i++){
				personagensFila[i] = personagensFila[i+1];
				personagensFila[i].GetComponent<PersonagemControl>().localFila = filaLocais[i];
			}

			personagensFila[quantidadeFila] = null;
		}
	}

	private void selecionarItem(string item){
		if(item == "COPO" && this.CopoSelect == false){
			if(GameManager.simulador.qtdCopo > 0){
				this.CopoSelect = true;	

				processador.ColocarCopo();
				GameManager.simulador.qtdCopo --;
			} else {
				hudControl.avisoControl.exibir("Você não possuí mais Copos!");
				this.fimSuprimentos = true;
			}
		}

		else if(item == "GELO" && this.CopoSelect && this.GeloSelect == false){
			if(GameManager.simulador.qtdGelo > 0){
				this.GeloSelect = true;		

				processador.ColocarGelo();
				GameManager.simulador.qtdGelo --;	
			} else {
				hudControl.avisoControl.exibir("Você não possuí mais Gelos!");
			}
		}

		else if(item == "LARANJA" ){
			if(GameManager.simulador.qtdLaranja > 0){
				processador.ColocarLaranja();
				this.FrutaSelect = true;
				this.SucoPreparado = item;
			} else {
				hudControl.avisoControl.exibir("Você não possuí mais Laranjas!");
				this.fimSuprimentos = true;
			}
		}

		else if(item == "LIMÃO" ){
			if(GameManager.simulador.qtdLimao > 0){
				processador.ColocarLimao();
				this.FrutaSelect = true;
				this.SucoPreparado = item;
			} else {
				hudControl.avisoControl.exibir("Você não possuí mais Limões!");
				this.fimSuprimentos = true;
			}
		}

		else if(item == "PÊSSEGO" ){
			if(GameManager.simulador.qtdPessego > 0){
				processador.ColocarPessego();
				this.FrutaSelect = true;
				this.SucoPreparado = item;
			} else {
				hudControl.avisoControl.exibir("Você não possuí mais Pêssegos!");
				this.fimSuprimentos = true;
			}
		}

		else if(item == "TAMARINDO" ){
			if(GameManager.simulador.qtdTamarindo > 0){
				processador.ColocarTamarindo();
				this.FrutaSelect = true;
				this.SucoPreparado = item;
			} else {
				hudControl.avisoControl.exibir("Você não possuí mais Tamarindos!");
				this.fimSuprimentos = true;
			}
		}

		else if(item == "UVA" ){
			if(GameManager.simulador.qtdUva > 0){
				processador.ColocarUva();
				this.FrutaSelect = true;
				this.SucoPreparado = item;
			} else {
				hudControl.avisoControl.exibir("Você não possuí mais Uvas!");
				this.fimSuprimentos = true;
			}
		}
	}

	private void validaSuco(){
		if( this.CopoSelect && this.FrutaSelect && personagensFila[0] != null ){
			//anima processador
			processador.ProcessaSuco();

			//aumenta satisfacao
			if(this.GeloSelect){
				personagensFila[0].GetComponent<PersonagemControl>().exibirBalaoSatisfacao("satisfeito");
				if(personagensFila[0].GetComponent<PersonagemControl>().satisfacao <= 100)
					personagensFila[0].GetComponent<PersonagemControl>().satisfacao += 10;

				GameManager.simulador.publicoSatisfeito++;
			}

			//baixa satisfacao
			if( SucoPreparado != personagensFila[0].GetComponent<PersonagemControl>().sucoDesejado ){
				personagensFila[0].GetComponent<PersonagemControl>().exibirBalaoSatisfacao("insatisfeito");
				personagensFila[0].GetComponent<PersonagemControl>().satisfacao -= 20;
				if(personagensFila[0].GetComponent<PersonagemControl>().satisfacao < 0)
					personagensFila[0].GetComponent<PersonagemControl>().satisfacao = 0;
			} else {
				personagensFila[0].GetComponent<PersonagemControl>().satisfacao += 5;
			}

			personagensFila[0].GetComponent<PersonagemControl>().sede = 0;

			//vende o suco
			debitaSuco(this.SucoPreparado);

			//zera variaveis
			this.GeloSelect = false;
			this.CopoSelect = false;	
			this.FrutaSelect = false;
			this.SucoPreparado = "";

			//faz cidadao sair da tenda
			Invoke("AndaFila", 2.3f);
		} else {
			//som
			audio.clip = erroSelecao;
			audio.Play ();
		}
	}

	private void debitaSuco(string suco){
		if(suco == "LARANJA"){
			GameManager.simulador.qtdLaranja --;

			GameManager.simulador.lucroLaranjaTurno += GameManager.simulador.prcSucoLaranja;
			GameManager.simulador.lucroLaranja += GameManager.simulador.prcSucoLaranja;

			GameManager.simulador.creditar(GameManager.simulador.prcSucoLaranja);
		}

		if(suco == "LIMÃO"){
			GameManager.simulador.qtdLimao --;

			GameManager.simulador.lucroLimaoTurno += GameManager.simulador.prcSucoLimao;
			GameManager.simulador.lucroLimao += GameManager.simulador.prcSucoLimao;

			GameManager.simulador.creditar(GameManager.simulador.prcSucoLimao);
		}
		
		if(suco == "PÊSSEGO"){
			GameManager.simulador.qtdPessego --;

			GameManager.simulador.lucroPessegoTurno += GameManager.simulador.prcSucoPessego;
			GameManager.simulador.lucroPessego += GameManager.simulador.prcSucoPessego;

			GameManager.simulador.creditar(GameManager.simulador.prcSucoPessego);
		}

		if(suco == "TAMARINDO"){
			GameManager.simulador.qtdTamarindo --;

			GameManager.simulador.lucroTamarindoTurno += GameManager.simulador.prcSucoTamarindo;
			GameManager.simulador.lucroTamarindo += GameManager.simulador.prcSucoTamarindo;

			GameManager.simulador.creditar(GameManager.simulador.prcSucoTamarindo);
		}

		if(suco == "UVA"){
			GameManager.simulador.qtdUva --;

			GameManager.simulador.lucroUvaTurno += GameManager.simulador.prcSucoUva;
			GameManager.simulador.lucroUva += GameManager.simulador.prcSucoUva;

			GameManager.simulador.creditar(GameManager.simulador.prcSucoUva);
		}
	}

}
