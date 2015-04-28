using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelResultadoControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

	/*
	 *  Sistema
	 */

	void Start () {
		
	}
	
	void Update () {
		
	}

	/*
	 *  Game
	 */	

	public void imprimirValores(){
		GameManager.simulador.popularBalancos();		

	}

}
