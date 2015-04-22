using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TendaHudControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

	public Button btnCls;
	public Button btnTrn;

	public Button btnBal;
	public GameObject pnlBal;	

	public Button btnPrc;
	public GameObject pnlPrc;	

	public GameObject hudAviso;
	public AvisoHudControl avisoControl;

	public GameObject hudGameOver;
	public GameOverHudControl gameOverControl;

	public GameObject hudGameWin;
	public GameOverHudControl gameWinControl;

	/*
	 *  Sistema
	 */

	void Start () {
		//oculta hud
		this.ocultar();
		
		//add listners
		btnCls.onClick.AddListener(() => { closeHud(); });
		btnTrn.onClick.AddListener(() => { iniciarSimulacao(); });

		//admin
		btnBal.onClick.AddListener(() => { abrirPainel("balanco"); });
		btnPrc.onClick.AddListener(() => { abrirPainel("precos"); });

		//aviso
		avisoControl = hudAviso.GetComponent<AvisoHudControl> ();

		//game over
		gameOverControl = hudGameOver.GetComponent<GameOverHudControl> ();
		gameWinControl = hudGameWin.GetComponent<GameOverHudControl> ();
	}

	void Update () {
	
	}

	/*
	 *  Game
	 */

	public void exibir() {
		GameManager.simulador.setStatusHud(true);
		gameObject.SetActive(true);

		//this.abrirPainel("balanco");
		this.abrirPainel("precos");
	}
	
	public void ocultar() {
		GameManager.simulador.setStatusHud(false);
		gameObject.SetActive(false);
	}
	
	public void closeHud(){
		this.ocultar();
		
		//fixar camera devolta ao cenario
		GameObject cameraObject = GameObject.FindWithTag ("MainCamera");
		CameraControl camera = cameraObject.GetComponent<CameraControl> ();
		
		camera.liberarCamera ();

		if( GameManager.simulador.ressetarFluxoDeCaixa == true ){
			GameManager.simulador.ressetarBalancos();
		}
	}

	public void iniciarSimulacao(){
		if( ( GameManager.simulador.getQtdLaranja() > 0 || GameManager.simulador.getQtdLimao() > 0 || GameManager.simulador.getQtdPessego() > 0 || GameManager.simulador.getQtdUva() > 0 || GameManager.simulador.getQtdTamarindo() > 0 ) && GameManager.simulador.getQtdCopo() > 0 ){
			//oculta hud	
			this.ocultar();			

			//inicia simulacao
			GameManager.simulador.iniciarSimulacao();
		} else {
			//aviso
			avisoControl.exibir("É necessário que você compre suprimentos mínimos!");
		}
	}

	public void abrirPainel(string painel){
		this.habilitarBotoes();

		pnlBal.SetActive(false);
		pnlPrc.SetActive(false);

		if( painel == "balanco" ) {
			pnlBal.SetActive(true);
			btnBal.interactable = false;
	
			pnlBal.GetComponent<PanelBalancoControl>().imprimirValores();
		}

		if( painel == "precos" ) {
			pnlPrc.SetActive(true);	
			btnPrc.interactable = false;
		}

	}

	private void habilitarBotoes(){
		btnBal.interactable = true;
		btnPrc.interactable = true;
	}
}
