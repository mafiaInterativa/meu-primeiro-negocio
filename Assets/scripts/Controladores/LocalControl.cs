using UnityEngine;
using System.Collections;

public class LocalControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */
	public int valor = 0; //valor terreno
	public int numeroLocalidade;

	public GameObject tenda;
	public GameObject tendaHud;
	public GameObject hudPlaca;

	public GameObject hudAviso;
	private AvisoHudControl avisoControl;

	public GameObject hudConfirmacao;
	private ConfirmacaoHudControl confirmacaoControl;

	private GameObject cameraObject;
	private CameraControl cameraControl;

	private Transform myLocal;
	
	/*
	 *  Sistema
	 */

	void Start () {
		//Camera
		cameraObject = GameObject.FindWithTag ("MainCamera");
		cameraControl = cameraObject.GetComponent<CameraControl> ();

		//aviso e confirmacao
		avisoControl = hudAviso.GetComponent<AvisoHudControl> ();
		confirmacaoControl = hudConfirmacao.GetComponent<ConfirmacaoHudControl> ();
		
		hudPlaca.GetComponent<HudPlacaControl>().valor.text = "$" + valor.ToString() + " / dia";
		hudPlaca.SetActive(false);
	}
	
	void Update () {

	}
	
	void FixedUpdate() {
		
	}
	
	void OnMouseOver () {
		HudPlacaControl hpc = hudPlaca.GetComponent<HudPlacaControl> ();
		hpc.exibir();
	}

	void OnMouseExit(){
		HudPlacaControl hpc = hudPlaca.GetComponent<HudPlacaControl> ();
		hpc.ocultar();
	}

	void OnMouseDown () {
		if( GameManager.simulador.getStatusHud() == false && cameraControl.lerpControl == false ){
			//define local
			myLocal = this.transform;		
	
			//exibe balao de confirmacao que executa a funcao abaixo
			confirmacaoControl.exibir("Você deseja alugar este local?", this);
		}
	}

	/*
	 *  Game
	 */

	public void EfetuarCompra(){

		//verifica orcamento
		//if (GameManager.simulador.getOrcamento() >= this.valor) {
			
			//verefica disponibilidade de construcao
			if (GameManager.simulador.getStatusConstrucao ()) {
				//grava localidade
				GameManager.simulador.numeroLocalidade = this.numeroLocalidade;

				//altera status variavel simulador
				GameManager.simulador.construir ();

				//setar valor do aluguel
				GameManager.simulador.aluguel = valor;

				//cria tenda no local deste obj
				GameObject tendaInstanciada = Instantiate( tenda, myLocal.transform.position, myLocal.transform.rotation) as GameObject;
				tendaInstanciada.GetComponent<TendaControl>().hud = tendaHud;

				HudPlacaControl hpc = hudPlaca.GetComponent<HudPlacaControl> ();
				hpc.ocultar();

				Destroy (gameObject);
			} else {
				//exibe balao com alerta
				avisoControl.exibir("Você ja possui uma tenda!");
			}
		//} else {
			//exibe balao de alerta
			//avisoControl.exibir("Você não possui orçamento suficiente para esta compra!");
		//}
	}

}
