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
			try{
				mediaTurnoCustoSucoLaranja = (( GameManager.simulador.custoLaranjaTurno / GameManager.simulador.qtdLaranjaTurno ) + ( GameManager.simulador.custoCopoTurno / GameManager.simulador.qtdCopoTurno ) + ( GameManager.simulador.custoGeloTurno / GameManager.simulador.qtdGeloTurno )) * GameManager.simulador.qtdLaranjaTurno;
				labelCustoSucoLaranjaTurno.text = "$ " + mediaTurnoCustoSucoLaranja .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelCustoSucoLaranjaTurno.text = "$ 00,00";
			}

			try{
				mediaTurnoCustoSucoLimao = (( GameManager.simulador.custoLimaoTurno / GameManager.simulador.qtdLimaoTurno ) + ( GameManager.simulador.custoCopoTurno / GameManager.simulador.qtdCopoTurno ) + ( GameManager.simulador.custoGeloTurno / GameManager.simulador.qtdGeloTurno ) ) * GameManager.simulador.qtdLimaoTurno;
				labelCustoSucoLimaoTurno.text = "$ " + mediaTurnoCustoSucoLimao .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelCustoSucoLimaoTurno.text = "$ 00,00";
			}

			try{
				mediaTurnoCustoSucoPessego = (( GameManager.simulador.custoPessegoTurno / GameManager.simulador.qtdPessegoTurno ) + ( GameManager.simulador.custoCopoTurno / GameManager.simulador.qtdCopoTurno ) + ( GameManager.simulador.custoGeloTurno / GameManager.simulador.qtdGeloTurno ) ) * GameManager.simulador.qtdPessegoTurno;
				labelCustoSucoPessegoTurno.text = "$ " + mediaTurnoCustoSucoPessego .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelCustoSucoPessegoTurno.text = "$ 00,00";
			}

			try{
				mediaTurnoCustoSucoTamarindo = (( GameManager.simulador.custoTamarindoTurno / GameManager.simulador.qtdTamarindoTurno ) + ( GameManager.simulador.custoCopoTurno / GameManager.simulador.qtdCopoTurno ) + ( GameManager.simulador.custoGeloTurno / GameManager.simulador.qtdGeloTurno ) ) * GameManager.simulador.qtdTamarindoTurno;
				labelCustoSucoTamarindoTurno.text = "$ " + mediaTurnoCustoSucoTamarindo .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelCustoSucoTamarindoTurno.text = "$ 00,00";
			}

			try{
				mediaTurnoCustoSucoUva = (( GameManager.simulador.custoUvaTurno / GameManager.simulador.qtdUvaTurno ) + ( GameManager.simulador.custoCopoTurno / GameManager.simulador.qtdCopoTurno ) + ( GameManager.simulador.custoGeloTurno / GameManager.simulador.qtdGeloTurno ) ) * GameManager.simulador.qtdUvaTurno;
				labelCustoSucoUvaTurno.text = "$ " + mediaTurnoCustoSucoUva .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelCustoSucoUvaTurno.text = "$ 00,00";
			}


			try{
				mediaTurnoReceitaSucoLaranja = GameManager.simulador.lucroLaranjaTurno;
				labelReceitaSucoLaranjaTurno.text = "$ " + mediaTurnoReceitaSucoLaranja .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelReceitaSucoLaranjaTurno.text = "$ 00,00";
			}

			try{
				mediaTurnoReceitaSucoLimao = GameManager.simulador.lucroLimaoTurno;
				labelReceitaSucoLimaoTurno.text = "$ " + mediaTurnoReceitaSucoLimao .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelReceitaSucoLimaoTurno.text = "$ 00,00";
			}

			try{
				mediaTurnoReceitaSucoPessego = GameManager.simulador.lucroPessegoTurno;
				labelReceitaSucoPessegoTurno.text = "$ " + mediaTurnoReceitaSucoPessego .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelReceitaSucoPessegoTurno.text = "$ 00,00";
			}

			try{
				mediaTurnoReceitaSucoTamarindo = GameManager.simulador.lucroTamarindoTurno;
				labelReceitaSucoTamarindoTurno.text = "$ " + mediaTurnoReceitaSucoTamarindo .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelReceitaSucoTamarindoTurno.text = "$ 00,00";
			}

			try{
				mediaTurnoReceitaSucoUva = GameManager.simulador.lucroUvaTurno;
				labelReceitaSucoUvaTurno.text = "$ " + mediaTurnoReceitaSucoUva .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelReceitaSucoUvaTurno.text = "$ 00,00";
			}
			
			labelLucroSucoLaranjaTurno.text = "$ " + (mediaTurnoReceitaSucoLaranja - mediaTurnoCustoSucoLaranja).ToString ("#.00");
			labelLucroSucoLimaoTurno.text = "$ " + (mediaTurnoReceitaSucoLimao - mediaTurnoCustoSucoLimao).ToString ("#.00");
			labelLucroSucoPessegoTurno.text = "$ " + (mediaTurnoReceitaSucoPessego - mediaTurnoCustoSucoPessego).ToString ("#.00");
			labelLucroSucoTamarindoTurno.text = "$ " + (mediaTurnoReceitaSucoTamarindo - mediaTurnoCustoSucoTamarindo).ToString ("#.00");
			labelLucroSucoUvaTurno.text = "$ " + (mediaTurnoReceitaSucoUva - mediaTurnoCustoSucoUva).ToString ("#.00");
		
		//acumulado
			
			try{
				mediaAcumuladoCustoSucoLaranja = (( GameManager.simulador.custoLaranja / GameManager.simulador.qtdLaranjaAcumulado ) + ( GameManager.simulador.custoCopo / GameManager.simulador.qtdCopoAcumulado ) + ( GameManager.simulador.custoGelo / GameManager.simulador.qtdGeloAcumulado ) ) * GameManager.simulador.qtdLaranjaAcumulado;
				labelCustoSucoLaranjaAcumulado.text = "$ " + mediaAcumuladoCustoSucoLaranja .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelCustoSucoLaranjaAcumulado.text = "$ 00,00";
			}
			
			try{
				mediaAcumuladoCustoSucoLimao = (( GameManager.simulador.custoLimao / GameManager.simulador.qtdLimaoAcumulado ) + ( GameManager.simulador.custoCopo / GameManager.simulador.qtdCopoAcumulado ) + ( GameManager.simulador.custoGelo / GameManager.simulador.qtdGeloAcumulado ) ) * GameManager.simulador.qtdLimaoAcumulado;
				labelCustoSucoLimaoAcumulado.text = "$ " + mediaAcumuladoCustoSucoLimao .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelCustoSucoLimaoAcumulado.text = "$ 00,00";
			}
			
			try{
				mediaAcumuladoCustoSucoPessego = (( GameManager.simulador.custoPessego / GameManager.simulador.qtdPessegoAcumulado ) + ( GameManager.simulador.custoCopo / GameManager.simulador.qtdCopoAcumulado ) + ( GameManager.simulador.custoGelo / GameManager.simulador.qtdGeloAcumulado ) ) * GameManager.simulador.qtdPessegoAcumulado;
				labelCustoSucoPessegoAcumulado.text = "$ " + mediaAcumuladoCustoSucoPessego .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelCustoSucoPessegoAcumulado.text = "$ 00,00";
			}
			
			try{
				mediaAcumuladoCustoSucoTamarindo = (( GameManager.simulador.custoTamarindo / GameManager.simulador.qtdTamarindoAcumulado ) + ( GameManager.simulador.custoCopo / GameManager.simulador.qtdCopoAcumulado ) + ( GameManager.simulador.custoGelo / GameManager.simulador.qtdGeloAcumulado ) ) * GameManager.simulador.qtdTamarindoAcumulado;
				labelCustoSucoTamarindoAcumulado.text = "$ " + mediaAcumuladoCustoSucoTamarindo .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelCustoSucoTamarindoAcumulado.text = "$ 00,00";
			}
			
			try{
				mediaAcumuladoCustoSucoUva = (( GameManager.simulador.custoUva / GameManager.simulador.qtdUvaAcumulado ) + ( GameManager.simulador.custoCopo / GameManager.simulador.qtdCopoAcumulado ) + ( GameManager.simulador.custoGelo / GameManager.simulador.qtdGeloAcumulado ) ) * GameManager.simulador.qtdUvaAcumulado;
				labelCustoSucoUvaAcumulado.text = "$ " + mediaAcumuladoCustoSucoUva .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelCustoSucoUvaAcumulado.text = "$ 00,00";
			}


			try{
				mediaAcumuladoReceitaSucoLaranja = GameManager.simulador.lucroLaranja;
				labelReceitaSucoLaranjaAcumulado.text = "$ " + mediaAcumuladoReceitaSucoLaranja .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelReceitaSucoLaranjaAcumulado.text = "$ 00,00";
			}
			
			try{
				mediaAcumuladoReceitaSucoLimao = GameManager.simulador.lucroLimao;
				labelReceitaSucoLimaoAcumulado.text = "$ " + mediaAcumuladoReceitaSucoLimao .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelReceitaSucoLimaoAcumulado.text = "$ 00,00";
			}
			
			try{
				mediaAcumuladoReceitaSucoPessego = GameManager.simulador.lucroPessego;
				labelReceitaSucoPessegoAcumulado.text = "$ " + mediaAcumuladoReceitaSucoPessego .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelReceitaSucoPessegoAcumulado.text = "$ 00,00";
			}
			
			try{
				mediaAcumuladoReceitaSucoTamarindo = GameManager.simulador.lucroTamarindo;
				labelReceitaSucoTamarindoAcumulado.text = "$ " + mediaAcumuladoReceitaSucoTamarindo .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelReceitaSucoTamarindoAcumulado.text = "$ 00,00";
			}
			
			try{
				mediaAcumuladoReceitaSucoUva = GameManager.simulador.lucroUva;
				labelReceitaSucoUvaAcumulado.text = "$ " + mediaAcumuladoReceitaSucoUva .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelReceitaSucoUvaAcumulado.text = "$ 00,00";
			}
		
			labelLucroSucoLaranjaAcumulado.text = "$ " + (mediaAcumuladoReceitaSucoLaranja - mediaAcumuladoCustoSucoLaranja).ToString ("#.00");
			labelLucroSucoLimaoAcumulado.text = "$ " + (mediaAcumuladoReceitaSucoLimao - mediaAcumuladoCustoSucoLimao).ToString ("#.00");
			labelLucroSucoPessegoAcumulado.text = "$ " + (mediaAcumuladoReceitaSucoPessego - mediaAcumuladoCustoSucoPessego).ToString ("#.00");
			labelLucroSucoTamarindoAcumulado.text = "$ " + (mediaAcumuladoReceitaSucoTamarindo - mediaAcumuladoCustoSucoTamarindo).ToString ("#.00");
			labelLucroSucoUvaAcumulado.text = "$ " + (mediaAcumuladoReceitaSucoUva - mediaAcumuladoCustoSucoUva).ToString ("#.00");




	}
}
