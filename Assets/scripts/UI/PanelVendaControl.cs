using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

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

		//valores

			public float mediaTurnoCustoSucoLaranja;
			public float mediaTurnoCustoSucoLimao;
			public float mediaTurnoCustoSucoPessego;
			public float mediaTurnoCustoSucoTamarindo;
			public float mediaTurnoCustoSucoUva;

			public float mediaTurnoReceitaSucoLaranja;
			public float mediaTurnoReceitaSucoLimao;
			public float mediaTurnoReceitaSucoPessego;
			public float mediaTurnoReceitaSucoTamarindo;
			public float mediaTurnoReceitaSucoUva;

			public float mediaAcumuladoCustoSucoLaranja;
			public float mediaAcumuladoCustoSucoLimao;
			public float mediaAcumuladoCustoSucoPessego;
			public float mediaAcumuladoCustoSucoTamarindo;
			public float mediaAcumuladoCustoSucoUva;
					
			public float mediaAcumuladoReceitaSucoLaranja;
			public float mediaAcumuladoReceitaSucoLimao;
			public float mediaAcumuladoReceitaSucoPessego;
			public float mediaAcumuladoReceitaSucoTamarindo;
			public float mediaAcumuladoReceitaSucoUva;

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
			mediaTurnoCustoSucoLaranja = GameManager.simulador.custoSucoLaranjaTurno;
			labelCustoSucoLaranjaTurno.text = "$ " + mediaTurnoCustoSucoLaranja .ToString ("0.00").Replace(".", ",");

			mediaTurnoCustoSucoLimao = GameManager.simulador.custoSucoLimaoTurno;
			labelCustoSucoLimaoTurno.text = "$ " + mediaTurnoCustoSucoLimao .ToString ("0.00").Replace(".", ",");

			mediaTurnoCustoSucoPessego = GameManager.simulador.custoSucoPessegoTurno;
			labelCustoSucoPessegoTurno.text = "$ " + mediaTurnoCustoSucoPessego .ToString ("0.00").Replace(".", ",");

			mediaTurnoCustoSucoTamarindo = GameManager.simulador.custoSucoTamarindoTurno;
			labelCustoSucoTamarindoTurno.text = "$ " + mediaTurnoCustoSucoTamarindo .ToString ("0.00").Replace(".", ",");

			mediaTurnoCustoSucoUva = GameManager.simulador.custoSucoUvaTurno;
			labelCustoSucoUvaTurno.text = "$ " + mediaTurnoCustoSucoUva .ToString ("0.00").Replace(".", ",");


			mediaTurnoReceitaSucoLaranja = GameManager.simulador.lucroLaranjaTurno;
			labelReceitaSucoLaranjaTurno.text = "$ " + mediaTurnoReceitaSucoLaranja .ToString ("0.00").Replace(".", ",");

			mediaTurnoReceitaSucoLimao = GameManager.simulador.lucroLimaoTurno;
			labelReceitaSucoLimaoTurno.text = "$ " + mediaTurnoReceitaSucoLimao .ToString ("0.00").Replace(".", ",");

			mediaTurnoReceitaSucoPessego = GameManager.simulador.lucroPessegoTurno;
			labelReceitaSucoPessegoTurno.text = "$ " + mediaTurnoReceitaSucoPessego .ToString ("0.00").Replace(".", ",");

			mediaTurnoReceitaSucoTamarindo = GameManager.simulador.lucroTamarindoTurno;
			labelReceitaSucoTamarindoTurno.text = "$ " + mediaTurnoReceitaSucoTamarindo .ToString ("0.00").Replace(".", ",");

			mediaTurnoReceitaSucoUva = GameManager.simulador.lucroUvaTurno;
			labelReceitaSucoUvaTurno.text = "$ " + mediaTurnoReceitaSucoUva .ToString ("0.00").Replace(".", ",");

			
			labelLucroSucoLaranjaTurno.text = "$ " + (mediaTurnoReceitaSucoLaranja - mediaTurnoCustoSucoLaranja).ToString ("0.00").Replace(".", ",");
			labelLucroSucoLimaoTurno.text = "$ " + (mediaTurnoReceitaSucoLimao - mediaTurnoCustoSucoLimao).ToString ("0.00").Replace(".", ",");
			labelLucroSucoPessegoTurno.text = "$ " + (mediaTurnoReceitaSucoPessego - mediaTurnoCustoSucoPessego).ToString ("0.00").Replace(".", ",");
			labelLucroSucoTamarindoTurno.text = "$ " + (mediaTurnoReceitaSucoTamarindo - mediaTurnoCustoSucoTamarindo).ToString ("0.00").Replace(".", ",");
			labelLucroSucoUvaTurno.text = "$ " + (mediaTurnoReceitaSucoUva - mediaTurnoCustoSucoUva).ToString ("0.00").Replace(".", ",");
		
		//acumulado
			mediaAcumuladoCustoSucoLaranja = GameManager.simulador.custoSucoLaranja;
			labelCustoSucoLaranjaAcumulado.text = "$ " + mediaAcumuladoCustoSucoLaranja .ToString ("0.00").Replace(".", ",");

			mediaAcumuladoCustoSucoLimao = GameManager.simulador.custoSucoLimao;
			labelCustoSucoLimaoAcumulado.text = "$ " + mediaAcumuladoCustoSucoLimao .ToString ("0.00").Replace(".", ",");

			mediaAcumuladoCustoSucoPessego = GameManager.simulador.custoSucoPessego;
			labelCustoSucoPessegoAcumulado.text = "$ " + mediaAcumuladoCustoSucoPessego .ToString ("0.00").Replace(".", ",");

			mediaAcumuladoCustoSucoTamarindo = GameManager.simulador.custoSucoTamarindo;
			labelCustoSucoTamarindoAcumulado.text = "$ " + mediaAcumuladoCustoSucoTamarindo .ToString ("0.00").Replace(".", ",");

			mediaAcumuladoCustoSucoUva = GameManager.simulador.custoSucoUva;
			labelCustoSucoUvaAcumulado.text = "$ " + mediaAcumuladoCustoSucoUva .ToString ("0.00").Replace(".", ",");
			

			mediaAcumuladoReceitaSucoLaranja = GameManager.simulador.lucroLaranja;
			labelReceitaSucoLaranjaAcumulado.text = "$ " + mediaAcumuladoReceitaSucoLaranja .ToString ("0.00").Replace(".", ",");

			mediaAcumuladoReceitaSucoLimao = GameManager.simulador.lucroLimao;
			labelReceitaSucoLimaoAcumulado.text = "$ " + mediaAcumuladoReceitaSucoLimao .ToString ("0.00").Replace(".", ",");
		
			mediaAcumuladoReceitaSucoPessego = GameManager.simulador.lucroPessego;
			labelReceitaSucoPessegoAcumulado.text = "$ " + mediaAcumuladoReceitaSucoPessego .ToString ("0.00").Replace(".", ",");

			mediaAcumuladoReceitaSucoTamarindo = GameManager.simulador.lucroTamarindo;
			labelReceitaSucoTamarindoAcumulado.text = "$ " + mediaAcumuladoReceitaSucoTamarindo .ToString ("0.00").Replace(".", ",");

			mediaAcumuladoReceitaSucoUva = GameManager.simulador.lucroUva;
			labelReceitaSucoUvaAcumulado.text = "$ " + mediaAcumuladoReceitaSucoUva .ToString ("0.00").Replace(".", ",");


			labelLucroSucoLaranjaAcumulado.text = "$ " + (mediaAcumuladoReceitaSucoLaranja - mediaAcumuladoCustoSucoLaranja).ToString ("0.00").Replace(".", ",");
			labelLucroSucoLimaoAcumulado.text = "$ " + (mediaAcumuladoReceitaSucoLimao - mediaAcumuladoCustoSucoLimao).ToString ("0.00").Replace(".", ",");
			labelLucroSucoPessegoAcumulado.text = "$ " + (mediaAcumuladoReceitaSucoPessego - mediaAcumuladoCustoSucoPessego).ToString ("0.00").Replace(".", ",");
			labelLucroSucoTamarindoAcumulado.text = "$ " + (mediaAcumuladoReceitaSucoTamarindo - mediaAcumuladoCustoSucoTamarindo).ToString ("0.00").Replace(".", ",");
			labelLucroSucoUvaAcumulado.text = "$ " + (mediaAcumuladoReceitaSucoUva - mediaAcumuladoCustoSucoUva).ToString ("0.00").Replace(".", ",");
	}
}
