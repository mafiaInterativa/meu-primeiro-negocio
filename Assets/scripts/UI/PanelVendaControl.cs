using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelVendaControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

		//turno
			public Text labelCustoSucoLaranjaTurno;
			public Text labelCustoSucoLimaoTurno;
			public Text labelCustoSucoPessegoTurno;
			public Text labelCustoSucoTamarindoTurno;
			public Text labelCustoSucoUvaTurno;

			public Text labelReceitaSucoLaranjaTurno;
			public Text labelReceitaSucoLimaoTurno;
			public Text labelReceitaSucoPessegoTurno;
			public Text labelReceitaSucoTamarindoTurno;
			public Text labelReceitaSucoUvaTurno;

			public Text labelLucroSucoLaranjaTurno;
			public Text labelLucroSucoLimaoTurno;
			public Text labelLucroSucoPessegoTurno;
			public Text labelLucroSucoTamarindoTurno;
			public Text labelLucroSucoUvaTurno;

		//acumulado
			public Text labelCustoSucoLaranjaAcumulado;
			public Text labelCustoSucoLimaoAcumulado;
			public Text labelCustoSucoPessegoAcumulado;
			public Text labelCustoSucoTamarindoAcumulado;
			public Text labelCustoSucoUvaAcumulado;
					
			public Text labelReceitaSucoLaranjaAcumulado;
			public Text labelReceitaSucoLimaoAcumulado;
			public Text labelReceitaSucoPessegoAcumulado;
			public Text labelReceitaSucoTamarindoAcumulado;
			public Text labelReceitaSucoUvaAcumulado;
					
			public Text labelLucroSucoLaranjaAcumulado;
			public Text labelLucroSucoLimaoAcumulado;
			public Text labelLucroSucoPessegoAcumulado;
			public Text labelLucroSucoTamarindoAcumulado;
			public Text labelLucroSucoUvaAcumulado;

	/*
	 *  Sistema
	 */

	void Start () {
		//turno
			labelCustoSucoLaranjaTurno.text = "$ 00,00";
			labelCustoSucoLimaoTurno.text = "$ 00,00";
			labelCustoSucoPessegoTurno.text = "$ 00,00";
			labelCustoSucoTamarindoTurno.text = "$ 00,00";
			labelCustoSucoUvaTurno.text = "$ 00,00";
			
			labelReceitaSucoLaranjaTurno.text = "$ 00,00";
			labelReceitaSucoLimaoTurno.text = "$ 00,00";
			labelReceitaSucoPessegoTurno.text = "$ 00,00";
			labelReceitaSucoTamarindoTurno.text = "$ 00,00";
			labelReceitaSucoUvaTurno.text = "$ 00,00";
			
			labelLucroSucoLaranjaTurno.text = "$ 00,00";
			labelLucroSucoLimaoTurno.text = "$ 00,00";
			labelLucroSucoPessegoTurno.text = "$ 00,00";
			labelLucroSucoTamarindoTurno.text = "$ 00,00";
			labelLucroSucoUvaTurno.text = "$ 00,00";
		
		//acumulado
			labelCustoSucoLaranjaAcumulado.text = "$ 00,00";
			labelCustoSucoLimaoAcumulado.text = "$ 00,00";
			labelCustoSucoPessegoAcumulado.text = "$ 00,00";
			labelCustoSucoTamarindoAcumulado.text = "$ 00,00";
			labelCustoSucoUvaAcumulado.text = "$ 00,00";
			
			labelReceitaSucoLaranjaAcumulado.text = "$ 00,00";
			labelReceitaSucoLimaoAcumulado.text = "$ 00,00";
			labelReceitaSucoPessegoAcumulado.text = "$ 00,00";
			labelReceitaSucoTamarindoAcumulado.text = "$ 00,00";
			labelReceitaSucoUvaAcumulado.text = "$ 00,00";
			
			labelLucroSucoLaranjaAcumulado.text = "$ 00,00";
			labelLucroSucoLimaoAcumulado.text = "$ 00,00";
			labelLucroSucoPessegoAcumulado.text = "$ 00,00";
			labelLucroSucoTamarindoAcumulado.text = "$ 00,00";
			labelLucroSucoUvaAcumulado.text = "$ 00,00";
	}
	
	void Update () {
		
	}

	/*
	 *  Game
	 */	

	public void imprimirValores(){
		GameManager.simulador.popularBalancos();		

		//turno
			labelCustoSucoLaranjaTurno.text = "$ 00,00";
			labelCustoSucoLimaoTurno.text = "$ 00,00";
			labelCustoSucoPessegoTurno.text = "$ 00,00";
			labelCustoSucoTamarindoTurno.text = "$ 00,00";
			labelCustoSucoUvaTurno.text = "$ 00,00";
			
			labelReceitaSucoLaranjaTurno.text = "$ 00,00";
			labelReceitaSucoLimaoTurno.text = "$ 00,00";
			labelReceitaSucoPessegoTurno.text = "$ 00,00";
			labelReceitaSucoTamarindoTurno.text = "$ 00,00";
			labelReceitaSucoUvaTurno.text = "$ 00,00";
			
			labelLucroSucoLaranjaTurno.text = "$ 00,00";
			labelLucroSucoLimaoTurno.text = "$ 00,00";
			labelLucroSucoPessegoTurno.text = "$ 00,00";
			labelLucroSucoTamarindoTurno.text = "$ 00,00";
			labelLucroSucoUvaTurno.text = "$ 00,00";
		
		//acumulado
			labelCustoSucoLaranjaAcumulado.text = "$ 00,00";
			labelCustoSucoLimaoAcumulado.text = "$ 00,00";
			labelCustoSucoPessegoAcumulado.text = "$ 00,00";
			labelCustoSucoTamarindoAcumulado.text = "$ 00,00";
			labelCustoSucoUvaAcumulado.text = "$ 00,00";
			
			labelReceitaSucoLaranjaAcumulado.text = "$ 00,00";
			labelReceitaSucoLimaoAcumulado.text = "$ 00,00";
			labelReceitaSucoPessegoAcumulado.text = "$ 00,00";
			labelReceitaSucoTamarindoAcumulado.text = "$ 00,00";
			labelReceitaSucoUvaAcumulado.text = "$ 00,00";
			
			labelLucroSucoLaranjaAcumulado.text = "$ 00,00";
			labelLucroSucoLimaoAcumulado.text = "$ 00,00";
			labelLucroSucoPessegoAcumulado.text = "$ 00,00";
			labelLucroSucoTamarindoAcumulado.text = "$ 00,00";
			labelLucroSucoUvaAcumulado.text = "$ 00,00";

	}
}
