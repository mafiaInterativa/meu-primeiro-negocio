using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class PanelCompraControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

		//turno
			public Text labelCustoTurnoLaranja;
			public Text labelCustoTurnoLimao;
			public Text labelCustoTurnoPessego;
			public Text labelCustoTurnoTamarindo;
			public Text labelCustoTurnoUva;
			public Text labelCustoTurnoCopo;
			public Text labelCustoTurnoGelo;

			public Text labelQuantidadeTurnoLaranja;
			public Text labelQuantidadeTurnoLimao;
			public Text labelQuantidadeTurnoPessego;
			public Text labelQuantidadeTurnoTamarindo;
			public Text labelQuantidadeTurnoUva;
			public Text labelQuantidadeTurnoCopo;
			public Text labelQuantidadeTurnoGelo;

			public Text labelMediaTurnoLaranja;
			public Text labelMediaTurnoLimao;
			public Text labelMediaTurnoPessego;
			public Text labelMediaTurnoTamarindo;
			public Text labelMediaTurnoUva;
			public Text labelMediaTurnoCopo;
			public Text labelMediaTurnoGelo;

		//acumulado
			public Text labelCustoAcumuladoLaranja;
			public Text labelCustoAcumuladoLimao;
			public Text labelCustoAcumuladoPessego;
			public Text labelCustoAcumuladoTamarindo;
			public Text labelCustoAcumuladoUva;
			public Text labelCustoAcumuladoCopo;
			public Text labelCustoAcumuladoGelo;
				
			public Text labelQuantidadeAcumuladoLaranja;
			public Text labelQuantidadeAcumuladoLimao;
			public Text labelQuantidadeAcumuladoPessego;
			public Text labelQuantidadeAcumuladoTamarindo;
			public Text labelQuantidadeAcumuladoUva;
			public Text labelQuantidadeAcumuladoCopo;
			public Text labelQuantidadeAcumuladoGelo;
				
			public Text labelMediaAcumuladoLaranja;
			public Text labelMediaAcumuladoLimao;
			public Text labelMediaAcumuladoPessego;
			public Text labelMediaAcumuladoTamarindo;
			public Text labelMediaAcumuladoUva;
			public Text labelMediaAcumuladoCopo;
			public Text labelMediaAcumuladoGelo;

	/*
	 *  Sistema
	 */

	void Start () {
		//turno
			labelCustoTurnoLaranja.text = "$ 00,00";
			labelCustoTurnoLimao.text = "$ 00,00";
			labelCustoTurnoPessego.text = "$ 00,00";
			labelCustoTurnoTamarindo.text = "$ 00,00";
			labelCustoTurnoUva.text = "$ 00,00";
			labelCustoTurnoCopo.text = "$ 00,00";
			labelCustoTurnoGelo.text = "$ 00,00";
			
			labelQuantidadeTurnoLaranja.text = "0";
			labelQuantidadeTurnoLimao.text = "0";
			labelQuantidadeTurnoPessego.text = "0";
			labelQuantidadeTurnoTamarindo.text = "0";
			labelQuantidadeTurnoUva.text = "0";
			labelQuantidadeTurnoCopo.text = "0";
			labelQuantidadeTurnoGelo.text = "0";
			
			labelMediaTurnoLaranja.text = "$ 00,00";
			labelMediaTurnoLimao.text = "$ 00,00";
			labelMediaTurnoPessego.text = "$ 00,00";
			labelMediaTurnoTamarindo.text = "$ 00,00";
			labelMediaTurnoUva.text = "$ 00,00";
			labelMediaTurnoCopo.text = "$ 00,00";
			labelMediaTurnoGelo.text = "$ 00,00";
		
		//acumulado
			labelCustoAcumuladoLaranja.text = "$ 00,00";
			labelCustoAcumuladoLimao.text = "$ 00,00";
			labelCustoAcumuladoPessego.text = "$ 00,00";
			labelCustoAcumuladoTamarindo.text = "$ 00,00";
			labelCustoAcumuladoUva.text = "$ 00,00";
			labelCustoAcumuladoCopo.text = "$ 00,00";
			labelCustoAcumuladoGelo.text = "$ 00,00";
		
			labelQuantidadeAcumuladoLaranja.text = "0";
			labelQuantidadeAcumuladoLimao.text = "0";
			labelQuantidadeAcumuladoPessego.text = "0";
			labelQuantidadeAcumuladoTamarindo.text = "0";
			labelQuantidadeAcumuladoUva.text = "0";
			labelQuantidadeAcumuladoCopo.text = "0";
			labelQuantidadeAcumuladoGelo.text = "0";
			
			labelMediaAcumuladoLaranja.text = "$ 00,00";
			labelMediaAcumuladoLimao.text = "$ 00,00";
			labelMediaAcumuladoPessego.text = "$ 00,00";
			labelMediaAcumuladoTamarindo.text = "$ 00,00";
			labelMediaAcumuladoUva.text = "$ 00,00";
			labelMediaAcumuladoCopo.text = "$ 00,00";
			labelMediaAcumuladoGelo.text = "$ 00,00";
	}
	
	void Update () {
		
	}

	/*
	 *  Game
	 */	

	public void imprimirValores() {

		GameManager.simulador.popularBalancos();		

		//turno
			labelCustoTurnoLaranja.text = "$ " + GameManager.simulador.custoLaranjaTurno .ToString ();
			labelCustoTurnoLimao.text = "$ " + GameManager.simulador.custoLimaoTurno .ToString ();
			labelCustoTurnoPessego.text = "$ " + GameManager.simulador.custoPessegoTurno .ToString ();
			labelCustoTurnoTamarindo.text = "$ " + GameManager.simulador.custoTamarindoTurno .ToString ();
			labelCustoTurnoUva.text = "$ " + GameManager.simulador.custoUvaTurno .ToString ();
			labelCustoTurnoCopo.text = "$ " + GameManager.simulador.custoCopoTurno .ToString ();
			labelCustoTurnoGelo.text = "$ " + GameManager.simulador.custoGeloTurno .ToString ();
			
			labelQuantidadeTurnoLaranja.text = GameManager.simulador.qtdLaranjaTurno .ToString ();
			labelQuantidadeTurnoLimao.text = GameManager.simulador.qtdLimaoTurno .ToString ();
			labelQuantidadeTurnoPessego.text = GameManager.simulador.qtdPessegoTurno .ToString ();
			labelQuantidadeTurnoTamarindo.text = GameManager.simulador.qtdTamarindoTurno .ToString ();
			labelQuantidadeTurnoUva.text = GameManager.simulador.qtdUvaTurno .ToString ();
			labelQuantidadeTurnoCopo.text = GameManager.simulador.qtdCopoTurno .ToString ();
			labelQuantidadeTurnoGelo.text = GameManager.simulador.qtdGeloTurno .ToString ();
			
			try{
				decimal mediaTurnoLaranja = ( GameManager.simulador.custoLaranjaTurno / GameManager.simulador.qtdLaranjaTurno );
				labelMediaTurnoLaranja.text = "$ " + mediaTurnoLaranja .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaTurnoLaranja.text = "$ 0,00";
			}

			try{
				decimal mediaTurnoLimao = ( GameManager.simulador.custoLimaoTurno / GameManager.simulador.qtdLimaoTurno );
				labelMediaTurnoLimao.text = "$ " + mediaTurnoLimao .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaTurnoLimao.text = "$ 0,00";
			}

			try{
				decimal mediaTurnoPessego = ( GameManager.simulador.custoPessegoTurno / GameManager.simulador.qtdPessegoTurno );
				labelMediaTurnoPessego.text = "$ " + mediaTurnoPessego .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaTurnoPessego.text = "$ 0,00";
			}

			try{
				decimal mediaTurnoTamarindo = ( GameManager.simulador.custoTamarindoTurno / GameManager.simulador.qtdTamarindoTurno );
				labelMediaTurnoTamarindo.text = "$ " + mediaTurnoTamarindo .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaTurnoTamarindo.text = "$ 0,00";
			}

			try{
				decimal mediaTurnoUva = ( GameManager.simulador.custoUvaTurno / GameManager.simulador.qtdUvaTurno ); 
				labelMediaTurnoUva.text = "$ " + mediaTurnoUva .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaTurnoUva.text = "$ 0,00";
			}

			try{
				decimal mediaTurnoCopo = ( GameManager.simulador.custoCopoTurno / GameManager.simulador.qtdCopoTurno );
				labelMediaTurnoCopo.text = "$ " + mediaTurnoCopo .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaTurnoCopo.text = "$ 0,00";
			}

			try{
				decimal mediaTurnoGelo = ( GameManager.simulador.custoGeloTurno / GameManager.simulador.qtdGeloTurno );
				labelMediaTurnoGelo.text = "$ " + mediaTurnoGelo .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaTurnoGelo.text = "$ 0,00";
			}
		
		//acumulado
			labelCustoAcumuladoLaranja.text = "$ " + GameManager.simulador.custoLaranja .ToString ();
			labelCustoAcumuladoLimao.text = "$ " + GameManager.simulador.custoLimao .ToString ();
			labelCustoAcumuladoPessego.text = "$ " + GameManager.simulador.custoPessego .ToString ();
			labelCustoAcumuladoTamarindo.text = "$ " + GameManager.simulador.custoTamarindo .ToString ();
			labelCustoAcumuladoUva.text = "$ " + GameManager.simulador.custoUva .ToString ();
			labelCustoAcumuladoCopo.text = "$ " + GameManager.simulador.custoCopo .ToString ();
			labelCustoAcumuladoGelo.text = "$ " + GameManager.simulador.custoGelo .ToString ();
			
			labelQuantidadeAcumuladoLaranja.text = GameManager.simulador.qtdLaranja .ToString ();
			labelQuantidadeAcumuladoLimao.text = GameManager.simulador.qtdLimao .ToString ();
			labelQuantidadeAcumuladoPessego.text = GameManager.simulador.qtdPessego .ToString ();
			labelQuantidadeAcumuladoTamarindo.text = GameManager.simulador.qtdTamarindo .ToString ();
			labelQuantidadeAcumuladoUva.text = GameManager.simulador.qtdUva .ToString ();
			labelQuantidadeAcumuladoCopo.text = GameManager.simulador.qtdCopo .ToString ();
			labelQuantidadeAcumuladoGelo.text = GameManager.simulador.qtdGelo .ToString ();
			
			try{
				decimal mediaLaranja = ( GameManager.simulador.custoLaranja / GameManager.simulador.qtdLaranja );
				labelMediaAcumuladoLaranja.text = "$ " + mediaLaranja .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoLaranja.text = "$ 0,00";
			}
			
			try{
				decimal mediaLimao = ( GameManager.simulador.custoLimao / GameManager.simulador.qtdLimao );
				labelMediaAcumuladoLimao.text = "$ " + mediaLimao .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoLimao.text = "$ 0,00";
			}
			
			try{
				decimal mediaPessego = ( GameManager.simulador.custoPessego / GameManager.simulador.qtdPessego );
				labelMediaAcumuladoPessego.text = "$ " + mediaPessego .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoPessego.text = "$ 0,00";
			}
			
			try{
				decimal mediaTamarindo = ( GameManager.simulador.custoTamarindo / GameManager.simulador.qtdTamarindo );
				labelMediaAcumuladoTamarindo.text = "$ " + mediaTamarindo .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoTamarindo.text = "$ 0,00";
			}
			
			try{
				decimal mediaUva = ( GameManager.simulador.custoUva / GameManager.simulador.qtdUva );
				labelMediaAcumuladoUva.text = "$ " + mediaUva .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoUva.text = "$ 0,00";
			}
			
			try{
				decimal mediaCopo = ( GameManager.simulador.custoCopo / GameManager.simulador.qtdCopo );
				labelMediaAcumuladoCopo.text = "$ " + mediaCopo .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoCopo.text = "$ 0,00";
			}
			
			try{
				decimal mediaGelo = ( GameManager.simulador.custoGelo / GameManager.simulador.qtdGelo );
				labelMediaAcumuladoGelo.text = "$ " + mediaGelo .ToString ();
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoGelo.text = "$ 0,00";
			}
			
	}
}
