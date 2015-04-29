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
			labelReceitaTurno.text = "$ " + (GameManager.simulador.lucroLaranjaTurno + GameManager.simulador.lucroLimaoTurno + GameManager.simulador.lucroPessegoTurno + GameManager.simulador.lucroTamarindoTurno + GameManager.simulador.lucroUvaTurno).ToString ("#.00");
			labelCustoTurno.text = "$ " + (GameManager.simulador.custoLaranjaTurno + GameManager.simulador.custoLimaoTurno + GameManager.simulador.custoPessegoTurno + GameManager.simulador.custoTamarindoTurno + GameManager.simulador.custoUvaTurno + GameManager.simulador.custoCopoTurno + GameManager.simulador.custoGeloTurno).ToString ("#.00");
				
			labelLaranjaTurno.text = "$ " + GameManager.simulador.custoLaranjaTurno.ToString ("#.00");
			labelLimaoTurno.text = "$ " + GameManager.simulador.custoLimaoTurno.ToString ("#.00");
			labelPessegoTurno.text = "$ " + GameManager.simulador.custoPessegoTurno.ToString ("#.00");
			labelTamarindoTurno.text = "$ " + GameManager.simulador.custoTamarindoTurno.ToString ("#.00");
			labelUvaTurno.text = "$ " + GameManager.simulador.custoUvaTurno.ToString ("#.00");
			labelCopoTurno.text = "$ " + GameManager.simulador.custoCopoTurno.ToString ("#.00");
			labelGeloTurno.text = "$ " + GameManager.simulador.custoGeloTurno.ToString ("#.00");
			
			labelMargemTurno.text = "$ " + ( (GameManager.simulador.lucroLaranjaTurno + GameManager.simulador.lucroLimaoTurno + GameManager.simulador.lucroPessegoTurno + GameManager.simulador.lucroTamarindoTurno + GameManager.simulador.lucroUvaTurno) - (GameManager.simulador.custoLaranjaTurno + GameManager.simulador.custoLimaoTurno + GameManager.simulador.custoPessegoTurno + GameManager.simulador.custoTamarindoTurno + GameManager.simulador.custoUvaTurno + GameManager.simulador.custoCopoTurno + GameManager.simulador.custoGeloTurno) ).ToString ("#.00");

			labelDespesasTurno.text = "$ " + GameManager.simulador.custoAluguelTurno.ToString ("#.00");
			labelAluguelTurno.text = "$ " + GameManager.simulador.custoAluguelTurno.ToString ("#.00");
			
			labelLucroTurno.text = "$ " + "$ " + ( ((GameManager.simulador.lucroLaranjaTurno + GameManager.simulador.lucroLimaoTurno + GameManager.simulador.lucroPessegoTurno + GameManager.simulador.lucroTamarindoTurno + GameManager.simulador.lucroUvaTurno) - (GameManager.simulador.custoLaranjaTurno + GameManager.simulador.custoLimaoTurno + GameManager.simulador.custoPessegoTurno + GameManager.simulador.custoTamarindoTurno + GameManager.simulador.custoUvaTurno + GameManager.simulador.custoCopoTurno + GameManager.simulador.custoGeloTurno)) - GameManager.simulador.custoAluguelTurno ).ToString ("#.00");
	
		//acumulado
			labelReceitaAcumulado.text = "$ " + ( GameManager.simulador.lucroLaranja + GameManager.simulador.lucroLimao + GameManager.simulador.lucroPessego + GameManager.simulador.lucroTamarindo + GameManager.simulador.lucroUva ).ToString ("#.00");
			labelCustoAcumulado.text = "$ " + ( GameManager.simulador.custoLaranja + GameManager.simulador.custoLimao + GameManager.simulador.custoPessego + GameManager.simulador.custoTamarindo + GameManager.simulador.custoUva + GameManager.simulador.custoCopo + GameManager.simulador.custoGelo ).ToString ("#.00");
			
			labelLaranjaAcumulado.text = "$ " + GameManager.simulador.custoLaranja.ToString ("#.00");
			labelLimaoAcumulado.text = "$ " + GameManager.simulador.custoLimao.ToString ("#.00");
			labelPessegoAcumulado.text = "$ " + GameManager.simulador.custoPessego.ToString ("#.00");
			labelTamarindoAcumulado.text = "$ " + GameManager.simulador.custoTamarindo.ToString ("#.00");
			labelUvaAcumulado.text = "$ " + GameManager.simulador.custoUva.ToString ("#.00");
			labelCopoAcumulado.text = "$ " + GameManager.simulador.custoCopo.ToString ("#.00");
			labelGeloAcumulado.text = "$ " + GameManager.simulador.custoGelo.ToString ("#.00");

			labelMargemAcumulado.text = "$ " + ( ( GameManager.simulador.lucroLaranja + GameManager.simulador.lucroLimao + GameManager.simulador.lucroPessego + GameManager.simulador.lucroTamarindo + GameManager.simulador.lucroUva ) - ( GameManager.simulador.custoLaranja + GameManager.simulador.custoLimao + GameManager.simulador.custoPessego + GameManager.simulador.custoTamarindo + GameManager.simulador.custoUva + GameManager.simulador.custoCopo + GameManager.simulador.custoGelo ) ).ToString ("#.00");;

			labelDespesasAcumulado.text = "$ " + GameManager.simulador.custoAluguel.ToString ("#.00");
			labelAluguelAcumulado.text = "$ " + GameManager.simulador.custoAluguel.ToString ("#.00");

			labelLucroAcumulado.text = "$ " + ( (( GameManager.simulador.lucroLaranja + GameManager.simulador.lucroLimao + GameManager.simulador.lucroPessego + GameManager.simulador.lucroTamarindo + GameManager.simulador.lucroUva ) - ( GameManager.simulador.custoLaranja + GameManager.simulador.custoLimao + GameManager.simulador.custoPessego + GameManager.simulador.custoTamarindo + GameManager.simulador.custoUva + GameManager.simulador.custoCopo + GameManager.simulador.custoGelo )) - GameManager.simulador.custoAluguel ).ToString ("#.00");
	}

}
