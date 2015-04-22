using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ComprasHudControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

	//hud
	public Button item01 = null;
	public Text lblItem01 = null;
	public Text vlrItem01 = null;	

	public Button item02 = null;
	public Text lblItem02 = null;
	public Text vlrItem02 = null;

	public Button item03 = null;
	public Text lblItem03 = null;
	public Text vlrItem03 = null;

	public Button item04 = null;
	public Text lblItem04 = null;
	public Text vlrItem04 = null;

	public Button item05 = null;
	public Text lblItem05 = null;
	public Text vlrItem05 = null;

	public Button item06 = null;
	public Text lblItem06 = null;
	public Text vlrItem06 = null;

	public Text cmpQtd;
	public Text cmpTotal;

	public Button btnAdd;
	public Button btnRmv;

	public Button btnCom;
	public Button btnCls;	

	//admin
	public int valorItem01;
	public int valorItem02;
	public int valorItem03;
	public int valorItem04;
	public int valorItem05;
	public int valorItem06;

	public int qtdMinima;

	private int valorTotal = 0;
	private int qtdTotal = 0;
	private string itemSelecionado = "";

	//aviso
	public GameObject hudAviso;
	private AvisoHudControl avisoControl;

	//som
	public AudioClip purchaseAudio; 
	public AudioClip openSound;

	/*
	 *  Sistema
	 */

	void Start () {
		//oculta hud
		this.ocultar();

		//add listners
		btnCls.onClick.AddListener(() => { closeHud(); });  
	
		if(item01 != null){
			item01.onClick.AddListener(() => { selecionarItem(item01, lblItem01.text.ToString () ); });
		}
		if(item02 != null){
			item02.onClick.AddListener(() => { selecionarItem(item02, lblItem02.text.ToString () ); });
		}
		if(item03 != null){		
			item03.onClick.AddListener(() => { selecionarItem(item03, lblItem03.text.ToString () ); });
		}
		if(item04 != null){
			item04.onClick.AddListener(() => { selecionarItem(item04, lblItem04.text.ToString () ); });
		}		
		if(item05 != null){
			item05.onClick.AddListener(() => { selecionarItem(item05, lblItem05.text.ToString () ); });
		}
		if(item06 != null){		
			item06.onClick.AddListener(() => { selecionarItem(item06, lblItem06.text.ToString () ); });
		}

		btnAdd.onClick.AddListener(() => { alterarQuantidade("+"); });
		btnRmv.onClick.AddListener(() => { alterarQuantidade("-"); });

		btnCom.onClick.AddListener(() => { comprar(); });

		//add valores hud
		if(vlrItem01 != null){
			vlrItem01.text = "$" + valorItem01.ToString ();
		}
		if(vlrItem02 != null){
			vlrItem02.text = "$" + valorItem02.ToString ();
		}
		if(vlrItem03 != null){
			vlrItem03.text = "$" + valorItem03.ToString ();
		}
		if(vlrItem04 != null){
			vlrItem04.text = "$" + valorItem04.ToString ();
		}
		if(vlrItem05 != null){
			vlrItem05.text = "$" + valorItem05.ToString ();
		}
		if(vlrItem06 != null){
			vlrItem06.text = "$" + valorItem06.ToString ();
		}

		this.ressetarValores();

		//aviso
		avisoControl = hudAviso.GetComponent<AvisoHudControl> ();
	}
	
	void Update () {
	
	}

	/*
	 *  Game
	 */
	
	//hud
	public void exibir() {
		GameManager.simulador.setStatusHud(true);
		gameObject.SetActive(true);
		
		//som
		audio.clip = openSound;
		audio.Play ();
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
	}
	
	//admin
	public void selecionarItem(Button item, string nomeItem){
		this.ressetarValores();
		
		habilitarBotoes();
		item.interactable = false;

		this.itemSelecionado = nomeItem;
	}

	private void habilitarBotoes(){
		if(item01 != null){
			item01.interactable = true;
		}
		if(item02 != null){	
			item02.interactable = true;
		}
		if(item03 != null){
			item03.interactable = true;
		}
		if(item04 != null){
			item04.interactable = true;
		}
		if(item05 != null){
			item05.interactable = true;
		}
		if(item06 != null){		
			item06.interactable = true;
		}
	}

	public void alterarQuantidade(string operador){
		if(this.itemSelecionado != ""){
			if(operador == "+"){
				qtdTotal += qtdMinima;
			}
	
			if(operador == "-" && qtdTotal > 0){
				qtdTotal -= qtdMinima;
			}
		}
		
		if(lblItem01 != null){
			if(itemSelecionado == lblItem01.text.ToString ()){
				valorTotal = qtdTotal * valorItem01;
			}
		}
		
		if(lblItem02 != null){
			if(itemSelecionado == lblItem02.text.ToString ()){
				valorTotal = qtdTotal * valorItem02;
			}
		}
		
		if(lblItem03 != null){
			if(itemSelecionado == lblItem03.text.ToString ()){
				valorTotal = qtdTotal * valorItem03;
			}
		}
		
		if(lblItem04 != null){
			if(itemSelecionado == lblItem04.text.ToString ()){
				valorTotal = qtdTotal * valorItem04;
			}
		}
		
		if(lblItem05 != null){
			if(itemSelecionado == lblItem05.text.ToString ()){
				valorTotal = qtdTotal * valorItem05;
			}
		}
		
		if(lblItem06 != null){
			if(itemSelecionado == lblItem06.text.ToString ()){
				valorTotal = qtdTotal * valorItem06;
			}
		}

		cmpQtd.text = qtdTotal.ToString ();
		cmpTotal.text = "$"+valorTotal.ToString ();
	}

	public void comprar(){
		this.habilitarBotoes();

		if(GameManager.simulador.getOrcamento() >= valorTotal){

			if(itemSelecionado == "LARANJA"){
				GameManager.simulador.setQtdLaranja(qtdTotal);

				GameManager.simulador.custoLaranjaTurno += valorTotal;
				GameManager.simulador.custoLaranja += valorTotal;
			}

			if(itemSelecionado == "LIMÃO"){
				GameManager.simulador.setQtdLimao(qtdTotal);
				
				GameManager.simulador.custoLimaoTurno += valorTotal;
				GameManager.simulador.custoLimao += valorTotal;
			}


			if(itemSelecionado == "UVA"){
				GameManager.simulador.setQtdUva(qtdTotal);

				GameManager.simulador.custoUvaTurno += valorTotal;
				GameManager.simulador.custoUva += valorTotal;
			}

			if(itemSelecionado == "TAMARINDO"){
				GameManager.simulador.setQtdTamarindo(qtdTotal);
				
				GameManager.simulador.custoTamarindoTurno += valorTotal;
				GameManager.simulador.custoTamarindo += valorTotal;
			}

			if(itemSelecionado == "PÊSSEGO"){
				GameManager.simulador.setQtdPessego(qtdTotal);
				
				GameManager.simulador.custoPessegoTurno += valorTotal;
				GameManager.simulador.custoPessego += valorTotal;
			}

			if(itemSelecionado == "COPO"){
				GameManager.simulador.setQtdCopo(qtdTotal);
				
				GameManager.simulador.custoCopoTurno += valorTotal;
				GameManager.simulador.custoCopo += valorTotal;
			}

			if(itemSelecionado == "GELO"){
				GameManager.simulador.setQtdGelo(qtdTotal);
				
				GameManager.simulador.custoGeloTurno += valorTotal;
				GameManager.simulador.custoGelo += valorTotal;
			}

			GameManager.simulador.debitar(valorTotal);

			this.ressetarValores();

			//som
			audio.clip = purchaseAudio;
			audio.Play ();	
		} else {
			//aviso
			avisoControl.exibir("Você não possui dinheiro suficiente para esta compra!");
		}
	}

	private void ressetarValores(){
		cmpQtd.text = "0";
		cmpTotal.text = "$0";

		valorTotal = 0;
		qtdTotal = 0;

		itemSelecionado = "";
	}	
}
