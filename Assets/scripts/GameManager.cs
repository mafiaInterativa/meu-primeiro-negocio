﻿using UnityEngine;
using System.Collections;
using System;

public class GameManager : MonoBehaviour {
	
	//inicia simulaçao
	public static Simulador simulador = new Simulador();

	//curso
	public Texture2D cursorPointer;
	public Texture2D cursorClick;

	private int cursorWidth = 32;
	private int cursorHeight = 32;

	//tenda
	public GameObject tenda;
	public GameObject tendaHud;

	void Start () {
		Screen.showCursor = false;

		QualitySettings.currentLevel = QualityLevel.Fantastic;
	}
	
	void Update () {	
		if (GameManager.simulador.pause == false)
		{
			Time.timeScale = 1;
		}
		
		else 
		{
			Time.timeScale = 0;
		}		
	}
	
	void FixedUpdate() {

	}

	void OnGUI()
	{
		if(simulador.mouseType == "pointer"){
			GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y-5, cursorWidth, cursorHeight), cursorPointer);
		}

		if(simulador.mouseType == "click"){
			GUI.DrawTexture(new Rect(Input.mousePosition.x-16, Screen.height - Input.mousePosition.y-16, cursorWidth, cursorHeight), cursorClick);
		}
	}

	public void carregarGame(){
		string info= simulador.carregar();

		string[] dados = info.Split(';');

		GameManager.simulador.nomeUsuario = dados[0];
		GameManager.simulador.emailUsuario= dados[1];
		GameManager.simulador.pontuacao = int.Parse( dados[2] );
		GameManager.simulador.orcamento = int.Parse( dados[3] );
		GameManager.simulador.aluguel = int.Parse( dados[4] );
		GameManager.simulador.turno = int.Parse( dados[5] );
		GameManager.simulador.statusConstrucao = Convert.ToBoolean( dados[6] );
		GameManager.simulador.numeroLocalidade = int.Parse( dados[7] );
		GameManager.simulador.qtdCopo = int.Parse( dados[8] );
		GameManager.simulador.qtdGelo = int.Parse( dados[9] );
		GameManager.simulador.qtdLaranja = int.Parse( dados[10] );
		GameManager.simulador.qtdLimao = int.Parse( dados[11] );
		GameManager.simulador.qtdPessego = int.Parse( dados[12] );
		GameManager.simulador.qtdTamarindo = int.Parse( dados[13] );
		GameManager.simulador.qtdUva = int.Parse( dados[14] );
		GameManager.simulador.qtdLaranjaAcumulado = int.Parse( dados[15] );
		GameManager.simulador.qtdLimaoAcumulado = int.Parse( dados[16] );
		GameManager.simulador.qtdUvaAcumulado = int.Parse( dados[17] );
		GameManager.simulador.qtdTamarindoAcumulado = int.Parse( dados[18] );
		GameManager.simulador.qtdPessegoAcumulado = int.Parse( dados[19] );
		GameManager.simulador.qtdGeloAcumulado = int.Parse( dados[20] );
		GameManager.simulador.qtdCopoAcumulado = int.Parse( dados[21] );
		GameManager.simulador.prcSucoLaranja = int.Parse( dados[22] );
		GameManager.simulador.prcSucoLimao = int.Parse( dados[23] );
		GameManager.simulador.prcSucoPessego = int.Parse( dados[24] );
		GameManager.simulador.prcSucoTamarindo = int.Parse( dados[25] );
		GameManager.simulador.prcSucoUva = int.Parse( dados[26] );
		GameManager.simulador.custoAluguel = int.Parse( dados[27] );
		GameManager.simulador.custoLaranja = int.Parse( dados[28] );
		GameManager.simulador.custoLimao = int.Parse( dados[29] );
		GameManager.simulador.custoPessego = int.Parse( dados[30] );
		GameManager.simulador.custoTamarindo = int.Parse( dados[31] );
		GameManager.simulador.custoUva = int.Parse( dados[32] );
		GameManager.simulador.custoCopo = int.Parse( dados[33] );
		GameManager.simulador.custoGelo = int.Parse( dados[34] );
		GameManager.simulador.custoTotal = int.Parse( dados[35] );
		GameManager.simulador.custoSucoLaranja = int.Parse( dados[36] );
		GameManager.simulador.custoSucoLimao = int.Parse( dados[37] );
		GameManager.simulador.custoSucoPessego = int.Parse( dados[38] );
		GameManager.simulador.custoSucoTamarindo = int.Parse( dados[39] );
		GameManager.simulador.custoSucoUva = int.Parse( dados[40] );
		GameManager.simulador.custoSucoLaranjaCopo = int.Parse( dados[41] );
		GameManager.simulador.custoSucoLaranjaGelo = int.Parse( dados[42] );
		GameManager.simulador.custoSucoLimaoCopo = int.Parse( dados[43] );
		GameManager.simulador.custoSucoLimaoGelo = int.Parse( dados[44] );
		GameManager.simulador.custoSucoPessegoCopo = int.Parse( dados[45] );
		GameManager.simulador.custoSucoPessegoGelo = int.Parse( dados[46] );
		GameManager.simulador.custoSucoTamarindoCopo = int.Parse( dados[47] );
		GameManager.simulador.custoSucoTamarindoGelo = int.Parse( dados[48] );
		GameManager.simulador.custoSucoUvaCopo = int.Parse( dados[49] );
		GameManager.simulador.custoSucoUvaGelo = int.Parse( dados[50] );
		GameManager.simulador.lucroLaranja = int.Parse( dados[51] );
		GameManager.simulador.lucroLimao = int.Parse( dados[52] );
		GameManager.simulador.lucroPessego = int.Parse( dados[53] );
		GameManager.simulador.lucroTamarindo = int.Parse( dados[54] );
		GameManager.simulador.lucroUva = int.Parse( dados[55] );
		GameManager.simulador.lucroTotal = int.Parse( dados[56] );
		
		GameObject[] placas;
		placas = GameObject.FindGameObjectsWithTag("Placa");

		for(int i=0; i < placas.Length; i++){
			LocalControl lc = placas[i].GetComponent<LocalControl> ();
			if ( lc.numeroLocalidade == GameManager.simulador.numeroLocalidade ) {
				
				GameObject tendaInstanciada = Instantiate( tenda, placas[i].transform.position, placas[i].transform.rotation) as GameObject;
				tendaInstanciada.GetComponent<TendaControl>().hud = lc.tendaHud;
				Destroy (placas[i]);

				break;
			}
		}

	}

}
