using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainHudControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */
	
	public Text cmpLaranja;
	public Text cmpLimao;
	public Text cmpPessego;
	public Text cmpTamarindo;
	public Text cmpUva;
	public Text cmpCopo;
	public Text cmpGelo;
	public Text cmpOrcamento;
	public Text cmpTurno;
	public Text cmpTempo;
	public Text cmpPontuacao;

	public GameObject boxTempo;

	public GameObject boxDica;
	private DicasHudControl dicasControl;

	/*
	 *  Sistema
	 */

	void Start () {

	}
	
	void Update () {
		//controles
			//exibe pontuacao
			Text lblPontuacao = cmpPontuacao.GetComponent<Text>();
			lblPontuacao.text = GameManager.simulador.getPontuacao().ToString ();

			//exibe orcamento
			Text lblOrcamento = cmpOrcamento.GetComponent<Text>();
			lblOrcamento.text = "$ " + GameManager.simulador.getOrcamento ().ToString ();
	
			//exibe turno
			Text lblTurno = cmpTurno.GetComponent<Text>();
			lblTurno.text = "Dia " + GameManager.simulador.getTurno ().ToString ();
	
			//exibe tempo
			Text lblTempo = cmpTempo.GetComponent<Text>();
			lblTempo.text = Mathf.Round ( GameManager.simulador.getTempoAtual ()).ToString () + "s";
			
			if(GameManager.simulador.statusVenda == true){
				boxTempo.SetActive(true);
			} else {
				boxTempo.SetActive(false);
			}

			//recursos
			//exibe laranjas
			Text lblLaranjas = cmpLaranja.GetComponent<Text>();
			lblLaranjas.text = GameManager.simulador.getQtdLaranja ().ToString ();

			//exibe limoes
			Text lblLimoes = cmpLimao.GetComponent<Text>();
			lblLimoes.text = GameManager.simulador.getQtdLimao ().ToString ();
	
			//exibe pessegos
			Text lblPessegos = cmpPessego.GetComponent<Text>();
			lblPessegos.text = GameManager.simulador.getQtdPessego ().ToString ();

			//exibe tamarindos
			Text lblTamarindos = cmpTamarindo.GetComponent<Text>();
			lblTamarindos.text = GameManager.simulador.getQtdTamarindo ().ToString ();
	
			//exibe uvas
			Text lblUvas = cmpUva.GetComponent<Text>();
			lblUvas.text = GameManager.simulador.getQtdUva ().ToString ();
	
			//exibe copos
			Text lblCopos = cmpCopo.GetComponent<Text>();
			lblCopos.text = GameManager.simulador.getQtdCopo ().ToString ();
	
			//exibe gelos
			Text lblGelos = cmpGelo.GetComponent<Text>();
			lblGelos.text = GameManager.simulador.getQtdGelo ().ToString ();

		//dicas
			dicasControl = boxDica.GetComponent<DicasHudControl>();
	
			if(dicasControl.exibindoDica == true && GameManager.simulador.statusHud == false && GameManager.simulador.statusVenda == false){
				dicasControl.exibindoDica = false;
				
				//exibe dica
				Invoke("dicas", 20);
			}
	}

	/*
	 *  Game
	 */

	public void exibir(){
		gameObject.SetActive(true);
	}

	public void ocultar(){
		gameObject.SetActive(false);
	}	

	public void dicas(){
		dicasControl.exibir();
	}
}
