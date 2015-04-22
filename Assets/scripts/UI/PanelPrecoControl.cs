using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelPrecoControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */
	
	public Button addItem01;
	public Button rmvItem01;
	public Text item01;
	
	public Button addItem02;
	public Button rmvItem02;
	public Text item02;

	public Button addItem03;
	public Button rmvItem03;
	public Text item03;

	public Button addItem04;
	public Button rmvItem04;
	public Text item04;

	public Button addItem05;
	public Button rmvItem05;
	public Text item05;

	public int qtdMinima = 1;

	/*
	 *  Sistema
	 */
	
	void Start () {
		this.imprimirValores();

		//add listners
		addItem01.onClick.AddListener(() => { alterarQtd(1, "+"); });
		rmvItem01.onClick.AddListener(() => { alterarQtd(1, "-"); });
		
		addItem02.onClick.AddListener(() => { alterarQtd(2, "+"); });
		rmvItem02.onClick.AddListener(() => { alterarQtd(2, "-"); });

		addItem03.onClick.AddListener(() => { alterarQtd(3, "+"); });
		rmvItem03.onClick.AddListener(() => { alterarQtd(3, "-"); });

		addItem04.onClick.AddListener(() => { alterarQtd(4, "+"); });
		rmvItem04.onClick.AddListener(() => { alterarQtd(4, "-"); });

		addItem05.onClick.AddListener(() => { alterarQtd(5, "+"); });
		rmvItem05.onClick.AddListener(() => { alterarQtd(5, "-"); });

	}
	
	
	void Update () {
		
	}
	
	/*
	 *  Game
	 */	

	public void alterarQtd(int item, string operador){
		if(item == 1){
			if(operador == "+"){
				GameManager.simulador.prcSucoLaranja += qtdMinima;
			}

			if(operador == "-" && GameManager.simulador.prcSucoLaranja > 0){
				GameManager.simulador.prcSucoLaranja -= qtdMinima;
			}
		}

		if(item == 2){
			if(operador == "+"){
				GameManager.simulador.prcSucoLimao += qtdMinima;
			}
			
			if(operador == "-" && GameManager.simulador.prcSucoLimao > 0){
				GameManager.simulador.prcSucoLimao -= qtdMinima;
			}
		}

		if(item == 3){
			if(operador == "+"){
				GameManager.simulador.prcSucoPessego += qtdMinima;
			}
			
			if(operador == "-" && GameManager.simulador.prcSucoPessego > 0){
				GameManager.simulador.prcSucoPessego -= qtdMinima;
			}
		}

		if(item == 4){
			if(operador == "+"){
				GameManager.simulador.prcSucoTamarindo += qtdMinima;
			}
			
			if(operador == "-" && GameManager.simulador.prcSucoUva > 0){
				GameManager.simulador.prcSucoTamarindo -= qtdMinima;
			}
		}

		if(item == 5){
			if(operador == "+"){
				GameManager.simulador.prcSucoUva += qtdMinima;
			}
			
			if(operador == "-" && GameManager.simulador.prcSucoUva > 0){
				GameManager.simulador.prcSucoUva -= qtdMinima;
			}
		}

		this.imprimirValores();
	}

	public void imprimirValores(){
		item01.text = "$" + GameManager.simulador.prcSucoLaranja .ToString ();
		item02.text = "$" + GameManager.simulador.prcSucoLimao .ToString ();
		item03.text = "$" + GameManager.simulador.prcSucoPessego .ToString ();
		item04.text = "$" + GameManager.simulador.prcSucoTamarindo .ToString ();
		item05.text = "$" + GameManager.simulador.prcSucoUva .ToString ();
	}
}
