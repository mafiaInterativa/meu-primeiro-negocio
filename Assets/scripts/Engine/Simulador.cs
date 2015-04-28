using UnityEngine;
using System;
using System.Collections;
using System.Text;

public class Simulador {

	/*
	 *  VARIAVEIS
	 */

		/* pontuacao */
			public int pontuacao = 0;

		/* orcamento */
			public int orcamento = 100;
			public int aluguel = 0;

		/* turno */
			public int turno = 0;
			public float tempoTotalTurno = 60.0f;
			private float tempoAtualTurno = 0;

		/* construcao */
			public int numeroLocalidade;

		/* recursos */
			public int qtdLaranja = 0;
			public int qtdLimao = 0;
			public int qtdUva = 0;
			public int qtdTamarindo = 0;
			public int qtdPessego = 0;
			public int qtdGelo = 0;
			public int qtdCopo = 0;	

			public int qtdLaranjaTurno = 0;
			public int qtdLimaoTurno = 0;
			public int qtdUvaTurno = 0;
			public int qtdTamarindoTurno = 0;
			public int qtdPessegoTurno = 0;
			public int qtdGeloTurno = 0;
			public int qtdCopoTurno = 0;	

			public int prcSucoLaranja = 5;	
			public int prcSucoLimao = 6;
			public int prcSucoUva = 11;
			public int prcSucoTamarindo = 14;
			public int prcSucoPessego = 7;

		/* controladores */
			public bool statusConstrucao = true;
			public bool statusVenda = false;
			public bool statusHud = false;
			public bool gameOver = false;
			public bool gameWin = false;
	
		/* balanco */
			public bool ressetarFluxoDeCaixa = false;

			//acumulado
			public int custoAluguel = 0;
			public int custoLaranja = 0;
			public int custoLimao = 0;
			public int custoPessego = 0;
			public int custoTamarindo = 0;
			public int custoUva = 0;
			public int custoCopo = 0;
			public int custoGelo = 0;
			public int custoTotal = 0;
					
			public int lucroLaranja = 0;
			public int lucroLimao = 0;
			public int lucroPessego = 0;
			public int lucroTamarindo = 0;
			public int lucroUva = 0;
			public int lucroTotal = 0;
					
			public int saldo = 0;			

			//turno
			public int custoAluguelTurno = 0;
			public int custoLaranjaTurno = 0;
			public int custoLimaoTurno = 0;
			public int custoPessegoTurno = 0;
			public int custoTamarindoTurno = 0;
			public int custoUvaTurno = 0;
			public int custoCopoTurno = 0;
			public int custoGeloTurno = 0;
			public int custoTotalTurno = 0;
			
			public int lucroLaranjaTurno = 0;
			public int lucroLimaoTurno = 0;
			public int lucroPessegoTurno = 0;
			public int lucroTamarindoTurno = 0;
			public int lucroUvaTurno = 0;
			public int lucroTotalTurno = 0;
		
			public int saldoTurno = 0;
	
		/* publico */
			public int publicoSatisfeito = 0;

		/* game config */
			//mouse
			public string mouseType = "pointer";
	
			//dados usuario
			public string nomeUsuario = "";
			public string emailUsuario = "";
	
			//game
			public bool pause = false;
			public string flagSave = "";
		
	/*
	 *  FUNCOES
	 */
		
		public Simulador(){	
			//starta variaveis
			this.turno = 1;

			this.tempoAtualTurno = this.tempoTotalTurno;
		}

		//fncs simulacao
		public void iniciarSimulacao(){
			this.statusVenda = true;

			if(this.ressetarFluxoDeCaixa == true){
				this.ressetarBalancos();
			}
		}

		public void pararSimulacao(){
			this.statusVenda = false;

			//desconta o aluguel
			this.custoAluguel += this.aluguel;
			this.custoAluguelTurno += this.aluguel;
			this.debitar(this.aluguel);

			//pontuacao
			if(this.saldoTurno > 0){
				pontuacao += this.saldoTurno * 100;
			}

			if(this.publicoSatisfeito > 0){
				pontuacao += this.publicoSatisfeito * 100;
			}

			//verifica game over
			if(this.orcamento <= 0){
				//perdeu
				this.gameOver = true;
			}
			
			if(this.pontuacao >= 1000000){
				//ganhou
				this.gameWin = true;
			}
		}

		public void popularBalancos(){
			//turno
			this.custoTotalTurno = this.custoAluguelTurno + this.custoLaranjaTurno + this.custoLimaoTurno + this.custoPessegoTurno + this.custoTamarindoTurno + this.custoUvaTurno + this.custoCopoTurno + this.custoGeloTurno;
			this.lucroTotalTurno = this.lucroLaranjaTurno + this.lucroLimaoTurno + this.lucroPessegoTurno + this.lucroTamarindoTurno + this.lucroUvaTurno;
			this.saldoTurno = this.lucroTotalTurno - this.custoTotalTurno;
			
			//acumulado
			this.custoTotal = this.custoAluguel + this.custoLaranja + this.custoLimao + this.custoPessego + this.custoTamarindo + this.custoUva + this.custoCopo + this.custoGelo;
			this.lucroTotal = this.lucroLaranja + this.lucroLimao + this.lucroPessego + this.lucroTamarindo + this.lucroUva;
			this.saldo = this.orcamento /*+ (this.lucroTotal - this.custoTotal)*/;
		}

		public void ressetarBalancos(){
			this.custoAluguelTurno = 0;

			this.custoLaranjaTurno = 0;
			this.custoLimaoTurno = 0;
			this.custoPessegoTurno = 0;
			this.custoTamarindoTurno = 0;
			this.custoUvaTurno = 0;
			this.custoCopoTurno = 0;
			this.custoGeloTurno = 0;
			this.custoTotalTurno = 0;
				
			this.lucroLaranjaTurno = 0;
			this.lucroLimaoTurno = 0;
			this.lucroPessegoTurno = 0;
			this.lucroTamarindoTurno = 0;
			this.lucroUvaTurno = 0;
			this.lucroTotalTurno = 0;

			this.qtdLaranjaTurno = 0;
			this.qtdLimaoTurno = 0;
			this.qtdUvaTurno = 0;
			this.qtdTamarindoTurno = 0;
			this.qtdPessegoTurno = 0;
			this.qtdGeloTurno = 0;
			this.qtdCopoTurno = 0;	
				
			this.saldoTurno = 0;

			this.publicoSatisfeito = 0;

			this.ressetarFluxoDeCaixa = false;
		}

		//fncs recurso
		public int getQtdLaranja(){
			return this.qtdLaranja;
		}

		public void setQtdLaranja(int qtd){
			this.qtdLaranja += qtd;
			this.qtdLaranjaTurno += qtd;
		}

		public int getQtdLimao(){
			return this.qtdLimao;
		}

		public void setQtdLimao(int qtd){
			this.qtdLimao += qtd;
			this.qtdLimaoTurno += qtd;
		}

		public int getQtdUva(){
			return this.qtdUva;
		}

		public void setQtdUva(int qtd){
			this.qtdUva += qtd;
			this.qtdUvaTurno += qtd;
		}

		public int getQtdTamarindo(){
			return this.qtdTamarindo;
		}

		public void setQtdTamarindo(int qtd){
			this.qtdTamarindo += qtd;
			this.qtdTamarindoTurno += qtd;
		}

		public int getQtdPessego(){
			return this.qtdPessego;
		}

		public void setQtdPessego(int qtd){
			this.qtdPessego += qtd;
			this.qtdPessegoTurno += qtd;
		}

		public int getQtdGelo(){
			return this.qtdGelo;
		}

		public void setQtdGelo(int qtd){
			this.qtdGelo += qtd;
			this.qtdGeloTurno += qtd;
		}

		public int getQtdCopo(){
			return this.qtdCopo;
		}

		public void setQtdCopo(int qtd){
			this.qtdCopo += qtd;
			this.qtdCopoTurno += qtd;
		}

		//fncs de turno
		public void reproduzirTurno(){
			if(this.tempoAtualTurno <= 0){
				this.encerarTurno();
			} else {
				this.tempoAtualTurno -= Time.deltaTime;
			}
		}

		public void encerarTurno(){
			this.tempoAtualTurno = this.tempoTotalTurno;
			this.turno++;
			
			this.pararSimulacao();
		}

		public int getTurno(){
			return this.turno;
		}

		public float getTempoAtual(){
			return this.tempoAtualTurno;
		}

		//fncs orcamentarias
		public void creditar(int valor){
			this.orcamento += valor;
		}

		public void debitar(int valor){
			this.orcamento -= valor;
		}

		public int getOrcamento(){
			return this.orcamento;
		}

		//fncs urbanizacao 
		public void construir(){
			this.statusConstrucao = false;
		}

		public bool getStatusConstrucao(){
			return this.statusConstrucao;
		}

		//hud
		public void setStatusHud(bool status){
			this.statusHud = status;
		}

		public bool getStatusHud(){
			return this.statusHud;
		}

		public int getPontuacao(){
			return this.pontuacao;
		}

		/*
		* LOAD AND SAVE
		*/

		public void salvar(string data){
			//salva dados
				byte[] bytesToEncode = Encoding.UTF8.GetBytes (data);
				string encodedText = Convert.ToBase64String (bytesToEncode);
	
				Debug.Log("Salvou: "+data);
				Debug.Log("Salvou Base64: " + encodedText);
	
				PlayerPrefs.SetString(flagSave, encodedText);
			
			//envia para a plataforma
				GameObject loginHud = GameObject.Find ("_Login");
				loginHud.GetComponent<UserService> ().SetHighScore(GameManager.simulador.pontuacao);
				loginHud.GetComponent<UserService> ().CallSendScore();
		}

		public string carregar(){
			string data = PlayerPrefs.GetString(flagSave);
			byte[] decodedBytes = Convert.FromBase64String ( data );
			string decodedText = Encoding.UTF8.GetString (decodedBytes);

			Debug.Log("Carregou: "+data);
			Debug.Log("Carregou Base64: " + decodedText);
		
			return decodedText;
		}
}
