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
			labelCustoTurno.text = "$ " + (GameManager.simulador.custoLaranjaTurno + GameManager.simulador.custoLimaoTurno + GameManager.simulador.custoPessegoTurno + GameManager.simulador.custoTamarindoTurno + GameManager.simulador.custoUvaTurno + GameManager.simulador.custoCopoTurno + GameManager.simulador.custoGeloTurno).ToString ("0.00").Replace(".", ",");
				
			labelLaranjaTurno.text = "$ " + GameManager.simulador.custoLaranjaTurno.ToString ("0.00").Replace(".", ",");
			labelLimaoTurno.text = "$ " + GameManager.simulador.custoLimaoTurno.ToString ("0.00").Replace(".", ",");
			labelPessegoTurno.text = "$ " + GameManager.simulador.custoPessegoTurno.ToString ("0.00").Replace(".", ",");
			labelTamarindoTurno.text = "$ " + GameManager.simulador.custoTamarindoTurno.ToString ("0.00").Replace(".", ",");
			labelUvaTurno.text = "$ " + GameManager.simulador.custoUvaTurno.ToString ("0.00").Replace(".", ",");
			labelCopoTurno.text = "$ " + GameManager.simulador.custoCopoTurno.ToString ("0.00").Replace(".", ",");
			labelGeloTurno.text = "$ " + GameManager.simulador.custoGeloTurno.ToString ("0.00").Replace(".", ",");
			
			labelMargemTurno.text = "$ " + ( (GameManager.simulador.lucroLaranjaTurno + GameManager.simulador.lucroLimaoTurno + GameManager.simulador.lucroPessegoTurno + GameManager.simulador.lucroTamarindoTurno + GameManager.simulador.lucroUvaTurno) - (GameManager.simulador.custoLaranjaTurno + GameManager.simulador.custoLimaoTurno + GameManager.simulador.custoPessegoTurno + GameManager.simulador.custoTamarindoTurno + GameManager.simulador.custoUvaTurno + GameManager.simulador.custoCopoTurno + GameManager.simulador.custoGeloTurno) ).ToString ("0.00").Replace(".", ",");

			labelDespesasTurno.text = "$ " + GameManager.simulador.custoAluguelTurno.ToString ("0.00").Replace(".", ",");
			labelAluguelTurno.text = "$ " + GameManager.simulador.custoAluguelTurno.ToString ("0.00").Replace(".", ",");
			
			labelLucroTurno.text = "$ " + ( ((GameManager.simulador.lucroLaranjaTurno + GameManager.simulador.lucroLimaoTurno + GameManager.simulador.lucroPessegoTurno + GameManager.simulador.lucroTamarindoTurno + GameManager.simulador.lucroUvaTurno) - (GameManager.simulador.custoLaranjaTurno + GameManager.simulador.custoLimaoTurno + GameManager.simulador.custoPessegoTurno + GameManager.simulador.custoTamarindoTurno + GameManager.simulador.custoUvaTurno + GameManager.simulador.custoCopoTurno + GameManager.simulador.custoGeloTurno)) - GameManager.simulador.custoAluguelTurno ).ToString ("0.00").Replace(".", ",");
	
		//acumulado
			labelReceitaAcumulado.text = "$ " + ( GameManager.simulador.lucroLaranja + GameManager.simulador.lucroLimao + GameManager.simulador.lucroPessego + GameManager.simulador.lucroTamarindo + GameManager.simulador.lucroUva ).ToString ("0.00").Replace(".", ",");
			labelCustoAcumulado.text = "$ " + ( GameManager.simulador.custoLaranja + GameManager.simulador.custoLimao + GameManager.simulador.custoPessego + GameManager.simulador.custoTamarindo + GameManager.simulador.custoUva + GameManager.simulador.custoCopo + GameManager.simulador.custoGelo ).ToString ("0.00").Replace(".", ",");
			
			labelLaranjaAcumulado.text = "$ " + GameManager.simulador.custoLaranja.ToString ("0.00").Replace(".", ",");
			labelLimaoAcumulado.text = "$ " + GameManager.simulador.custoLimao.ToString ("0.00").Replace(".", ",");
			labelPessegoAcumulado.text = "$ " + GameManager.simulador.custoPessego.ToString ("0.00").Replace(".", ",");
			labelTamarindoAcumulado.text = "$ " + GameManager.simulador.custoTamarindo.ToString ("0.00").Replace(".", ",");
			labelUvaAcumulado.text = "$ " + GameManager.simulador.custoUva.ToString ("0.00").Replace(".", ",");
			labelCopoAcumulado.text = "$ " + GameManager.simulador.custoCopo.ToString ("0.00").Replace(".", ",");
			labelGeloAcumulado.text = "$ " + GameManager.simulador.custoGelo.ToString ("0.00").Replace(".", ",");

			labelMargemAcumulado.text = "$ " + ( ( GameManager.simulador.lucroLaranja + GameManager.simulador.lucroLimao + GameManager.simulador.lucroPessego + GameManager.simulador.lucroTamarindo + GameManager.simulador.lucroUva ) - ( GameManager.simulador.custoLaranja + GameManager.simulador.custoLimao + GameManager.simulador.custoPessego + GameManager.simulador.custoTamarindo + GameManager.simulador.custoUva + GameManager.simulador.custoCopo + GameManager.simulador.custoGelo ) ).ToString ("0.00").Replace(".", ",");;

			labelDespesasAcumulado.text = "$ " + GameManager.simulador.custoAluguel.ToString ("0.00").Replace(".", ",");
			labelAluguelAcumulado.text = "$ " + GameManager.simulador.custoAluguel.ToString ("0.00").Replace(".", ",");

			labelLucroAcumulado.text = "$ " + ( (( GameManager.simulador.lucroLaranja + GameManager.simulador.lucroLimao + GameManager.simulador.lucroPessego + GameManager.simulador.lucroTamarindo + GameManager.simulador.lucroUva ) - ( GameManager.simulador.custoLaranja + GameManager.simulador.custoLimao + GameManager.simulador.custoPessego + GameManager.simulador.custoTamarindo + GameManager.simulador.custoUva + GameManager.simulador.custoCopo + GameManager.simulador.custoGelo )) - GameManager.simulador.custoAluguel ).ToString ("0.00").Replace(".", ",");
	}

}
