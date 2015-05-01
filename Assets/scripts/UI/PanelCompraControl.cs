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
			labelCustoTurnoLaranja.text = "$ " + GameManager.simulador.custoLaranjaTurno .ToString ("0.00");
			labelCustoTurnoLimao.text = "$ " + GameManager.simulador.custoLimaoTurno .ToString ("0.00");
			labelCustoTurnoPessego.text = "$ " + GameManager.simulador.custoPessegoTurno .ToString ("0.00");
			labelCustoTurnoTamarindo.text = "$ " + GameManager.simulador.custoTamarindoTurno .ToString ("0.00");
			labelCustoTurnoUva.text = "$ " + GameManager.simulador.custoUvaTurno .ToString ("0.00");
			labelCustoTurnoCopo.text = "$ " + GameManager.simulador.custoCopoTurno .ToString ("0.00");
			labelCustoTurnoGelo.text = "$ " + GameManager.simulador.custoGeloTurno .ToString ("0.00");
			
			labelQuantidadeTurnoLaranja.text = GameManager.simulador.qtdLaranjaTurno .ToString ();
			labelQuantidadeTurnoLimao.text = GameManager.simulador.qtdLimaoTurno .ToString ();
			labelQuantidadeTurnoPessego.text = GameManager.simulador.qtdPessegoTurno .ToString ();
			labelQuantidadeTurnoTamarindo.text = GameManager.simulador.qtdTamarindoTurno .ToString ();
			labelQuantidadeTurnoUva.text = GameManager.simulador.qtdUvaTurno .ToString ();
			labelQuantidadeTurnoCopo.text = GameManager.simulador.qtdCopoTurno .ToString ();
			labelQuantidadeTurnoGelo.text = GameManager.simulador.qtdGeloTurno .ToString ();
			
			try{
				float mediaTurnoLaranja = ( GameManager.simulador.custoLaranjaTurno / GameManager.simulador.qtdLaranjaTurno );
				
				if( !float.IsNaN(mediaTurnoLaranja) ){
					labelMediaTurnoLaranja.text = "$ " + mediaTurnoLaranja .ToString ("0.00");
				} else {
					labelMediaTurnoLaranja.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaTurnoLaranja.text = "$ 0.00";
			}

			try{
				float mediaTurnoLimao = ( GameManager.simulador.custoLimaoTurno / GameManager.simulador.qtdLimaoTurno );

				if( !float.IsNaN(mediaTurnoLimao) ){
					labelMediaTurnoLimao.text = "$ " + mediaTurnoLimao .ToString ("0.00");
				} else {
					labelMediaTurnoLimao.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaTurnoLimao.text = "$ 0.00";
			}

			try{
				float mediaTurnoPessego = ( GameManager.simulador.custoPessegoTurno / GameManager.simulador.qtdPessegoTurno );

				if( !float.IsNaN(mediaTurnoPessego) ){
					labelMediaTurnoPessego.text = "$ " + mediaTurnoPessego .ToString ("0.00");
				} else {
					labelMediaTurnoPessego.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaTurnoPessego.text = "$ 0.00";
			}

			try{
				float mediaTurnoTamarindo = ( GameManager.simulador.custoTamarindoTurno / GameManager.simulador.qtdTamarindoTurno );
				
				if( !float.IsNaN(mediaTurnoTamarindo) ){
					labelMediaTurnoTamarindo.text = "$ " + mediaTurnoTamarindo .ToString ("0.00");
				} else {
					labelMediaTurnoTamarindo.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaTurnoTamarindo.text = "$ 0.00";
			}

			try{
				float mediaTurnoUva = ( GameManager.simulador.custoUvaTurno / GameManager.simulador.qtdUvaTurno ); 

				if( !float.IsNaN(mediaTurnoUva) ){
					labelMediaTurnoUva.text = "$ " + mediaTurnoUva .ToString ("0.00");
				} else {
					labelMediaTurnoUva.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaTurnoUva.text = "$ 0.00";
			}

			try{
				float mediaTurnoCopo = ( GameManager.simulador.custoCopoTurno / GameManager.simulador.qtdCopoTurno );

				if( !float.IsNaN(mediaTurnoCopo) ){
					labelMediaTurnoCopo.text = "$ " + mediaTurnoCopo .ToString ("0.00");
				} else {
					labelMediaTurnoCopo.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaTurnoCopo.text = "$ 0.00";
			}

			try{
				float mediaTurnoGelo = ( GameManager.simulador.custoGeloTurno / GameManager.simulador.qtdGeloTurno );

				if( !float.IsNaN(mediaTurnoGelo) ){
					labelMediaTurnoGelo.text = "$ " + mediaTurnoGelo .ToString ("0.00");
				} else {
					labelMediaTurnoGelo.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaTurnoGelo.text = "$ 0.00";
			}
		
			//acumulado
			labelCustoAcumuladoLaranja.text = "$ " + GameManager.simulador.custoLaranja .ToString ("0.00");
			labelCustoAcumuladoLimao.text = "$ " + GameManager.simulador.custoLimao .ToString ("0.00");
			labelCustoAcumuladoPessego.text = "$ " + GameManager.simulador.custoPessego .ToString ("0.00");
			labelCustoAcumuladoTamarindo.text = "$ " + GameManager.simulador.custoTamarindo .ToString ("0.00");
			labelCustoAcumuladoUva.text = "$ " + GameManager.simulador.custoUva .ToString ("0.00");
			labelCustoAcumuladoCopo.text = "$ " + GameManager.simulador.custoCopo .ToString ("0.00");
			labelCustoAcumuladoGelo.text = "$ " + GameManager.simulador.custoGelo .ToString ("0.00");
			
			labelQuantidadeAcumuladoLaranja.text = GameManager.simulador.qtdLaranjaAcumulado .ToString ();
			labelQuantidadeAcumuladoLimao.text = GameManager.simulador.qtdLimaoAcumulado .ToString ();
			labelQuantidadeAcumuladoPessego.text = GameManager.simulador.qtdPessegoAcumulado .ToString ();
			labelQuantidadeAcumuladoTamarindo.text = GameManager.simulador.qtdTamarindo .ToString ();
			labelQuantidadeAcumuladoUva.text = GameManager.simulador.qtdUvaAcumulado .ToString ();
			labelQuantidadeAcumuladoCopo.text = GameManager.simulador.qtdCopoAcumulado .ToString ();
			labelQuantidadeAcumuladoGelo.text = GameManager.simulador.qtdGeloAcumulado .ToString ();
			
			try{
				float mediaLaranja = ( GameManager.simulador.custoLaranja / GameManager.simulador.qtdLaranjaAcumulado );

				if( !float.IsNaN(mediaLaranja) ){
					labelMediaAcumuladoLaranja.text = "$ " + mediaLaranja .ToString ("0.00");
				} else {
					labelMediaAcumuladoLaranja.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoLaranja.text = "$ 0.00";
			}
			
			try{
				float mediaLimao = ( GameManager.simulador.custoLimao / GameManager.simulador.qtdLimaoAcumulado );

				if( !float.IsNaN(mediaLimao) ){
					labelMediaAcumuladoLimao.text = "$ " + mediaLimao .ToString ("0.00");
				} else {
					labelMediaAcumuladoLimao.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoLimao.text = "$ 0.00";
			}
			
			try{
				float mediaPessego = ( GameManager.simulador.custoPessego / GameManager.simulador.qtdPessegoAcumulado );

				if( !float.IsNaN(mediaPessego) ){
					labelMediaAcumuladoPessego.text = "$ " + mediaPessego .ToString ("0.00");
				} else {
					labelMediaAcumuladoPessego.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoPessego.text = "$ 0.00";
			}
			
			try{
				float mediaTamarindo = ( GameManager.simulador.custoTamarindo / GameManager.simulador.qtdTamarindoAcumulado );

				if( !float.IsNaN(mediaTamarindo) ){
					labelMediaAcumuladoTamarindo.text = "$ " + mediaTamarindo .ToString ("0.00");
				} else {
					labelMediaAcumuladoTamarindo.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoTamarindo.text = "$ 0.00";
			}
			
			try{
				float mediaUva = ( GameManager.simulador.custoUva / GameManager.simulador.qtdUvaAcumulado );

				if( !float.IsNaN(mediaUva) ){
					labelMediaAcumuladoUva.text = "$ " + mediaUva .ToString ("0.00");
				} else {
					labelMediaAcumuladoUva.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoUva.text = "$ 0.00";
			}
			
			try{
				float mediaCopo = ( GameManager.simulador.custoCopo / GameManager.simulador.qtdCopoAcumulado );

				if( !float.IsNaN(mediaCopo) ){
					labelMediaAcumuladoCopo.text = "$ " + mediaCopo .ToString ("0.00");
				} else {
					labelMediaAcumuladoCopo.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoCopo.text = "$ 0.00";
			}
			
			try{
				float mediaGelo = ( GameManager.simulador.custoGelo / GameManager.simulador.qtdGeloAcumulado );

				if( !float.IsNaN(mediaGelo) ){
					labelMediaAcumuladoGelo.text = "$ " + mediaGelo .ToString ("0.00");
				} else {
					labelMediaAcumuladoGelo.text = "$ 0.00";
				}
			} catch (DivideByZeroException e) {
				labelMediaAcumuladoGelo.text = "$ 0.00";
			}
			
	}
}
