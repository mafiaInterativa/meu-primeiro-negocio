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

	}
	
	void Update () {
		
	}

	/*
	 *  Game
	 */	

	public void imprimirValores() {

			//turno
			labelCustoTurnoLaranja.text = "$ " + GameManager.simulador.custoLaranjaTurno .ToString ("#.00");
			labelCustoTurnoLimao.text = "$ " + GameManager.simulador.custoLimaoTurno .ToString ("#.00");
			labelCustoTurnoPessego.text = "$ " + GameManager.simulador.custoPessegoTurno .ToString ("#.00");
			labelCustoTurnoTamarindo.text = "$ " + GameManager.simulador.custoTamarindoTurno .ToString ("#.00");
			labelCustoTurnoUva.text = "$ " + GameManager.simulador.custoUvaTurno .ToString ("#.00");
			labelCustoTurnoCopo.text = "$ " + GameManager.simulador.custoCopoTurno .ToString ("#.00");
			labelCustoTurnoGelo.text = "$ " + GameManager.simulador.custoGeloTurno .ToString ("#.00");
			
			labelQuantidadeTurnoLaranja.text = GameManager.simulador.qtdLaranjaTurno .ToString ();
			labelQuantidadeTurnoLimao.text = GameManager.simulador.qtdLimaoTurno .ToString ();
			labelQuantidadeTurnoPessego.text = GameManager.simulador.qtdPessegoTurno .ToString ();
			labelQuantidadeTurnoTamarindo.text = GameManager.simulador.qtdTamarindoTurno .ToString ();
			labelQuantidadeTurnoUva.text = GameManager.simulador.qtdUvaTurno .ToString ();
			labelQuantidadeTurnoCopo.text = GameManager.simulador.qtdCopoTurno .ToString ();
			labelQuantidadeTurnoGelo.text = GameManager.simulador.qtdGeloTurno .ToString ();
			
			try{
				float mediaTurnoLaranja = ( GameManager.simulador.custoLaranjaTurno / GameManager.simulador.qtdLaranjaTurno );
			labelMediaTurnoLaranja.text = "$ " + mediaTurnoLaranja .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaTurnoLaranja.text = "$ 0,00";
			}

			try{
				float mediaTurnoLimao = ( GameManager.simulador.custoLimaoTurno / GameManager.simulador.qtdLimaoTurno );
				labelMediaTurnoLimao.text = "$ " + mediaTurnoLimao .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaTurnoLimao.text = "$ 0,00";
			}

			try{
				float mediaTurnoPessego = ( GameManager.simulador.custoPessegoTurno / GameManager.simulador.qtdPessegoTurno );
				labelMediaTurnoPessego.text = "$ " + mediaTurnoPessego .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaTurnoPessego.text = "$ 0,00";
			}

			try{
				float mediaTurnoTamarindo = ( GameManager.simulador.custoTamarindoTurno / GameManager.simulador.qtdTamarindoTurno );
				labelMediaTurnoTamarindo.text = "$ " + mediaTurnoTamarindo .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaTurnoTamarindo.text = "$ 0,00";
			}

			try{
				float mediaTurnoUva = ( GameManager.simulador.custoUvaTurno / GameManager.simulador.qtdUvaTurno ); 
				labelMediaTurnoUva.text = "$ " + mediaTurnoUva .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaTurnoUva.text = "$ 0,00";
			}

			try{
				float mediaTurnoCopo = ( GameManager.simulador.custoCopoTurno / GameManager.simulador.qtdCopoTurno );
				labelMediaTurnoCopo.text = "$ " + mediaTurnoCopo .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaTurnoCopo.text = "$ 0,00";
			}

			try{
				float mediaTurnoGelo = ( GameManager.simulador.custoGeloTurno / GameManager.simulador.qtdGeloTurno );
				labelMediaTurnoGelo.text = "$ " + mediaTurnoGelo .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaTurnoGelo.text = "$ 0,00";
			}
		
			//acumulado
			labelCustoAcumuladoLaranja.text = "$ " + GameManager.simulador.custoLaranja .ToString ("#.00");
			labelCustoAcumuladoLimao.text = "$ " + GameManager.simulador.custoLimao .ToString ("#.00");
			labelCustoAcumuladoPessego.text = "$ " + GameManager.simulador.custoPessego .ToString ("#.00");
			labelCustoAcumuladoTamarindo.text = "$ " + GameManager.simulador.custoTamarindo .ToString ("#.00");
			labelCustoAcumuladoUva.text = "$ " + GameManager.simulador.custoUva .ToString ("#.00");
			labelCustoAcumuladoCopo.text = "$ " + GameManager.simulador.custoCopo .ToString ("#.00");
			labelCustoAcumuladoGelo.text = "$ " + GameManager.simulador.custoGelo .ToString ("#.00");
			
			labelQuantidadeAcumuladoLaranja.text = GameManager.simulador.qtdLaranjaAcumulado .ToString ();
			labelQuantidadeAcumuladoLimao.text = GameManager.simulador.qtdLimaoAcumulado .ToString ();
			labelQuantidadeAcumuladoPessego.text = GameManager.simulador.qtdPessegoAcumulado .ToString ();
			labelQuantidadeAcumuladoTamarindo.text = GameManager.simulador.qtdTamarindo .ToString ();
			labelQuantidadeAcumuladoUva.text = GameManager.simulador.qtdUvaAcumulado .ToString ();
			labelQuantidadeAcumuladoCopo.text = GameManager.simulador.qtdCopoAcumulado .ToString ();
			labelQuantidadeAcumuladoGelo.text = GameManager.simulador.qtdGeloAcumulado .ToString ();
			
			try{
				float mediaLaranja = ( GameManager.simulador.custoLaranja / GameManager.simulador.qtdLaranjaAcumulado );
				labelMediaAcumuladoLaranja.text = "$ " + mediaLaranja .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoLaranja.text = "$ 0,00";
			}
			
			try{
				float mediaLimao = ( GameManager.simulador.custoLimao / GameManager.simulador.qtdLimaoAcumulado );
				labelMediaAcumuladoLimao.text = "$ " + mediaLimao .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoLimao.text = "$ 0,00";
			}
			
			try{
				float mediaPessego = ( GameManager.simulador.custoPessego / GameManager.simulador.qtdPessegoAcumulado );
				labelMediaAcumuladoPessego.text = "$ " + mediaPessego .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoPessego.text = "$ 0,00";
			}
			
			try{
				float mediaTamarindo = ( GameManager.simulador.custoTamarindo / GameManager.simulador.qtdTamarindoAcumulado );
				labelMediaAcumuladoTamarindo.text = "$ " + mediaTamarindo .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoTamarindo.text = "$ 0,00";
			}
			
			try{
				float mediaUva = ( GameManager.simulador.custoUva / GameManager.simulador.qtdUvaAcumulado );
				labelMediaAcumuladoUva.text = "$ " + mediaUva .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoUva.text = "$ 0,00";
			}
			
			try{
				float mediaCopo = ( GameManager.simulador.custoCopo / GameManager.simulador.qtdCopoAcumulado );
				labelMediaAcumuladoCopo.text = "$ " + mediaCopo .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoCopo.text = "$ 0,00";
			}
			
			try{
				float mediaGelo = ( GameManager.simulador.custoGelo / GameManager.simulador.qtdGeloAcumulado );
				labelMediaAcumuladoGelo.text = "$ " + mediaGelo .ToString ("#.00");
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoGelo.text = "$ 0,00";
			}
			
	}
}
