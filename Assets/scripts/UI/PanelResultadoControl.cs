using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelResultadoControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

		//turno
			public Text labelReceitaTurno;
			public Text labelCustoTurno;
			public Text labelLaranjaTurno;
			public Text labelLimaoTurno;
			public Text labelPessegoTurno;
			public Text labelTamarindoTurno;
			public Text labelUvaTurno;
			public Text labelCopoTurno;
			public Text labelGeloTurno;
			public Text labelMargemTurno;
			public Text labelDespesasTurno;
			public Text labelAluguelTurno;
			public Text labelLucroTurno;

		//acumulado
			public Text labelReceitaAcumulado;
			public Text labelCustoAcumulado;
			public Text labelLaranjaAcumulado;
			public Text labelLimaoAcumulado;
			public Text labelPessegoAcumulado;
			public Text labelTamarindoAcumulado;
			public Text labelUvaAcumulado;
			public Text labelCopoAcumulado;
			public Text labelGeloAcumulado;
			public Text labelMargemAcumulado;
			public Text labelDespesasAcumulado;
			public Text labelAluguelAcumulado;
			public Text labelLucroAcumulado;

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

		//turno
			labelReceitaTurno.text = "$ " + (GameManager.simulador.lucroLaranjaTurno + GameManager.simulador.lucroLimaoTurno + GameManager.simulador.lucroPessegoTurno + GameManager.simulador.lucroTamarindoTurno + GameManager.simulador.lucroUvaTurno).ToString ("0.00").Replace(".", ",");
			labelCustoTurno.text = "$ " + (GameManager.simulador.custoSucoLaranjaTurno + GameManager.simulador.custoSucoLimaoTurno + GameManager.simulador.custoSucoPessegoTurno + GameManager.simulador.custoSucoTamarindoTurno + GameManager.simulador.custoSucoUvaTurno).ToString ("0.00").Replace(".", ",");
				
			labelLaranjaTurno.text = "$ " + (GameManager.simulador.custoSucoLaranjaTurno - GameManager.simulador.custoSucoLaranjaCopoTurno - GameManager.simulador.custoSucoLaranjaGeloTurno) .ToString ("0.00").Replace(".", ",");
			labelLimaoTurno.text = "$ " + (GameManager.simulador.custoSucoLimaoTurno - GameManager.simulador.custoSucoLimaoCopoTurno - GameManager.simulador.custoSucoLimaoGeloTurno) .ToString ("0.00").Replace(".", ",");
			labelPessegoTurno.text = "$ " + (GameManager.simulador.custoSucoPessegoTurno - GameManager.simulador.custoSucoPessegoCopoTurno - GameManager.simulador.custoSucoPessegoGeloTurno) .ToString ("0.00").Replace(".", ",");
			labelTamarindoTurno.text = "$ " + (GameManager.simulador.custoSucoTamarindoTurno - GameManager.simulador.custoSucoTamarindoCopoTurno - GameManager.simulador.custoSucoTamarindoGeloTurno) .ToString ("0.00").Replace(".", ",");
			labelUvaTurno.text = "$ " + (GameManager.simulador.custoSucoUvaTurno - GameManager.simulador.custoSucoUvaCopoTurno - GameManager.simulador.custoSucoUvaGeloTurno) .ToString ("0.00").Replace(".", ",");
			labelCopoTurno.text = "$ " + (GameManager.simulador.custoSucoLaranjaCopoTurno + GameManager.simulador.custoSucoLimaoCopoTurno + GameManager.simulador.custoSucoPessegoCopoTurno + GameManager.simulador.custoSucoTamarindoCopoTurno + GameManager.simulador.custoSucoUvaCopoTurno) .ToString ("0.00").Replace(".", ",");
			labelGeloTurno.text = "$ " + (GameManager.simulador.custoSucoLaranjaGeloTurno + GameManager.simulador.custoSucoLimaoGeloTurno + GameManager.simulador.custoSucoPessegoGeloTurno + GameManager.simulador.custoSucoTamarindoGeloTurno + GameManager.simulador.custoSucoUvaGeloTurno) .ToString ("0.00").Replace(".", ",");
			
			labelMargemTurno.text = "$ " + ( (GameManager.simulador.lucroLaranjaTurno + GameManager.simulador.lucroLimaoTurno + GameManager.simulador.lucroPessegoTurno + GameManager.simulador.lucroTamarindoTurno + GameManager.simulador.lucroUvaTurno) - (GameManager.simulador.custoSucoLaranjaTurno + GameManager.simulador.custoSucoLimaoTurno + GameManager.simulador.custoSucoPessegoTurno + GameManager.simulador.custoSucoTamarindoTurno + GameManager.simulador.custoSucoUvaTurno) ).ToString ("0.00").Replace(".", ",");

			labelDespesasTurno.text = "$ " + GameManager.simulador.custoAluguelTurno.ToString ("0.00").Replace(".", ",");
			labelAluguelTurno.text = "$ " + GameManager.simulador.custoAluguelTurno.ToString ("0.00").Replace(".", ",");
			
			labelLucroTurno.text = "$ " + ( ((GameManager.simulador.lucroLaranjaTurno + GameManager.simulador.lucroLimaoTurno + GameManager.simulador.lucroPessegoTurno + GameManager.simulador.lucroTamarindoTurno + GameManager.simulador.lucroUvaTurno) - (GameManager.simulador.custoSucoLaranjaTurno + GameManager.simulador.custoSucoLimaoTurno + GameManager.simulador.custoSucoPessegoTurno + GameManager.simulador.custoSucoTamarindoTurno + GameManager.simulador.custoSucoUvaTurno)) - GameManager.simulador.custoAluguelTurno ).ToString ("0.00").Replace(".", ",");
	
		//acumulado
			labelReceitaAcumulado.text = "$ " + ( GameManager.simulador.lucroLaranja + GameManager.simulador.lucroLimao + GameManager.simulador.lucroPessego + GameManager.simulador.lucroTamarindo + GameManager.simulador.lucroUva ).ToString ("0.00").Replace(".", ",");
			labelCustoAcumulado.text = "$ " + (GameManager.simulador.custoSucoLaranja + GameManager.simulador.custoSucoLimao + GameManager.simulador.custoSucoPessego + GameManager.simulador.custoSucoTamarindo + GameManager.simulador.custoSucoUva).ToString ("0.00").Replace(".", ",");
			
			labelLaranjaAcumulado.text = "$ " + (GameManager.simulador.custoSucoLaranja - GameManager.simulador.custoSucoLaranjaCopo - GameManager.simulador.custoSucoLaranjaGelo) .ToString ("0.00").Replace(".", ",");
			labelLimaoAcumulado.text = "$ " + (GameManager.simulador.custoSucoLimao - GameManager.simulador.custoSucoLimaoCopo - GameManager.simulador.custoSucoLimaoGelo) .ToString ("0.00").Replace(".", ",");
			labelPessegoAcumulado.text = "$ " + (GameManager.simulador.custoSucoPessego - GameManager.simulador.custoSucoPessegoCopo - GameManager.simulador.custoSucoPessegoGelo) .ToString ("0.00").Replace(".", ",");
			labelTamarindoAcumulado.text = "$ " + (GameManager.simulador.custoSucoTamarindo - GameManager.simulador.custoSucoTamarindoCopo - GameManager.simulador.custoSucoTamarindoGelo) .ToString ("0.00").Replace(".", ",");
			labelUvaAcumulado.text = "$ " + (GameManager.simulador.custoSucoUva - GameManager.simulador.custoSucoUvaCopo - GameManager.simulador.custoSucoUvaGelo) .ToString ("0.00").Replace(".", ",");
			labelCopoAcumulado.text = "$ " + (GameManager.simulador.custoSucoLaranjaCopo + GameManager.simulador.custoSucoLimaoCopo + GameManager.simulador.custoSucoPessegoCopo + GameManager.simulador.custoSucoTamarindoCopo + GameManager.simulador.custoSucoUvaCopo) .ToString ("0.00").Replace(".", ",");
			labelGeloAcumulado.text = "$ " + (GameManager.simulador.custoSucoLaranjaGelo + GameManager.simulador.custoSucoLimaoGelo + GameManager.simulador.custoSucoPessegoGelo + GameManager.simulador.custoSucoTamarindoGelo + GameManager.simulador.custoSucoUvaGelo) .ToString ("0.00").Replace(".", ",");

			labelMargemAcumulado.text = "$ " + ( ( GameManager.simulador.lucroLaranja + GameManager.simulador.lucroLimao + GameManager.simulador.lucroPessego + GameManager.simulador.lucroTamarindo + GameManager.simulador.lucroUva ) - ( GameManager.simulador.custoSucoLaranja + GameManager.simulador.custoSucoLimao + GameManager.simulador.custoSucoPessego + GameManager.simulador.custoSucoTamarindo + GameManager.simulador.custoSucoUva ) ).ToString ("0.00").Replace(".", ",");;

			labelDespesasAcumulado.text = "$ " + GameManager.simulador.custoAluguel.ToString ("0.00").Replace(".", ",");
			labelAluguelAcumulado.text = "$ " + GameManager.simulador.custoAluguel.ToString ("0.00").Replace(".", ",");

			labelLucroAcumulado.text = "$ " + ( (( GameManager.simulador.lucroLaranja + GameManager.simulador.lucroLimao + GameManager.simulador.lucroPessego + GameManager.simulador.lucroTamarindo + GameManager.simulador.lucroUva ) - ( GameManager.simulador.custoSucoLaranja + GameManager.simulador.custoSucoLimao + GameManager.simulador.custoSucoPessego + GameManager.simulador.custoSucoTamarindo + GameManager.simulador.custoSucoUva )) - GameManager.simulador.custoAluguel ).ToString ("0.00").Replace(".", ",");
	}

}
