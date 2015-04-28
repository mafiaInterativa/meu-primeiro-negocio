using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TendaHudControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

	public Button btnCls;
	public Button btnTrn;

	public Button btnVendas;
	public GameObject pnlVendas;	

	public Button btnCompras;
	public GameObject pnlCompras;

	public Button btnResultados;
	public GameObject pnlResultados;

	public Button btnPrecos;
	public GameObject pnlPrecos;	

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
		btnVendas.onClick.AddListener(() => { abrirPainel("vendas"); });
		btnCompras.onClick.AddListener(() => { abrirPainel("compras"); });
		btnResultados.onClick.AddListener(() => { abrirPainel("resultados"); });
		btnPrecos.onClick.AddListener(() => { abrirPainel("precos"); });

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
		this.desabilitarPaineis();

		if( painel == "vendas" ) {
			pnlVendas.SetActive(true);
			btnVendas.interactable = false;
	
			pnlVendas.GetComponent<PanelVendaControl>().imprimirValores();
		}

		if( painel == "compras" ) {
			pnlCompras.SetActive(true);
			btnCompras.interactable = false;

			pnlCompras.GetComponent<PanelCompraControl>().imprimirValores();
		}

		if( painel == "resultados" ) {
			pnlResultados.SetActive(true);
			btnResultados.interactable = false;

			pnlResultados.GetComponent<PanelResultadoControl>().imprimirValores();
		}

		if( painel == "precos" ) {
			pnlPrecos.SetActive(true);	
			btnPrecos.interactable = false;
		}
	}

	private void habilitarBotoes(){
		btnVendas.interactable = true;
		btnCompras.interactable = true;
		btnResultados.interactable = true;
		btnPrecos.interactable = true;
	}

	private void desabilitarBotoes(){
		btnVendas.interactable = true;
		btnCompras.interactable = true;
		btnResultados.interactable = true;
		btnPrecos.interactable = true;
	}

	private void habilitarPaineis(){
		pnlVendas.SetActive(true);
		pnlCompras.SetActive(true);
		pnlResultados.SetActive(true);
		pnlPrecos.SetActive(true);
	}
	
	private void desabilitarPaineis(){
		pnlVendas.SetActive(false);
		pnlCompras.SetActive(false);
		pnlResultados.SetActive(false);
		pnlPrecos.SetActive(false);
	}
}
