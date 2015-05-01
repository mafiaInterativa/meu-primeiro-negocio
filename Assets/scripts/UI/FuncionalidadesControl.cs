using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FuncionalidadesControl : MonoBehaviour {
	
	/*
	 *  VARIAVEIS
	 */

	public Button btnPausar;
	public Button btnSom;
	public Button btnSalvar;

	public Image estPause;
	public Image estSom;

	public Sprite somOn;
	public Sprite somOff;

	public Sprite gameOn;
	public Sprite gameOff;

	private bool muted = false;

	/*
	 *  Sistema
	 */

	void Start () {
		//listners
		btnPausar.onClick.AddListener(() => { pausarGame(); });
		btnSom.onClick.AddListener(() => { desligarSom(); });
		btnSalvar.onClick.AddListener(() => { salvarGame(); });
	}

	void Update () {
	
	}

	/*
	 *  Game
	 */
	
	public void pausarGame(){
		if (GameManager.simulador.pause == true)
		{
			GameManager.simulador.pause = false;
			estPause.sprite = gameOff;
		}	
		else
		{
			GameManager.simulador.pause = true;
			estPause.sprite = gameOn;
		}
	}

	public void desligarSom(){
		if (!muted)
		{
			AudioListener.volume = 0.0f;
			estSom.sprite = somOn;
			muted = true;
		}
		else
		{
			AudioListener.volume = 1.0f;
			estSom.sprite = somOff;
			muted = false;
		}
	}

	public void salvarGame(){
		string salvarDado =   
							  GameManager.simulador.nomeUsuario + ";" 
							+ GameManager.simulador.emailUsuario + ";" 
							+ GameManager.simulador.pontuacao.ToString() + ";" 
							+ GameManager.simulador.orcamento.ToString() + ";" 
							+ GameManager.simulador.aluguel.ToString() + ";" 
							+ GameManager.simulador.turno.ToString() + ";" 
							+ GameManager.simulador.statusConstrucao.ToString() + ";"
							+ GameManager.simulador.numeroLocalidade.ToString() + ";" 
							+ GameManager.simulador.qtdCopo.ToString() + ";" 
							+ GameManager.simulador.qtdGelo.ToString() + ";" 
							+ GameManager.simulador.qtdLaranja.ToString() + ";" 
							+ GameManager.simulador.qtdLimao.ToString() + ";" 
							+ GameManager.simulador.qtdPessego.ToString() + ";" 
							+ GameManager.simulador.qtdTamarindo.ToString() + ";" 
							+ GameManager.simulador.qtdUva.ToString() + ";" 
							+ GameManager.simulador.qtdLaranjaAcumulado.ToString() + ";" 
							+ GameManager.simulador.qtdLimaoAcumulado.ToString() + ";" 
							+ GameManager.simulador.qtdUvaAcumulado.ToString() + ";" 
							+ GameManager.simulador.qtdTamarindoAcumulado.ToString() + ";" 
							+ GameManager.simulador.qtdPessegoAcumulado.ToString() + ";" 
							+ GameManager.simulador.qtdGeloAcumulado.ToString() + ";" 
							+ GameManager.simulador.qtdCopoAcumulado.ToString() + ";" 
							+ GameManager.simulador.prcSucoLaranja.ToString() + ";" 
							+ GameManager.simulador.prcSucoLimao.ToString() + ";" 
							+ GameManager.simulador.prcSucoPessego.ToString() + ";"
							+ GameManager.simulador.prcSucoTamarindo.ToString() + ";" 
							+ GameManager.simulador.prcSucoUva.ToString() + ";" 
							+ GameManager.simulador.custoAluguel.ToString() + ";"
							+ GameManager.simulador.custoLaranja.ToString() + ";"
							+ GameManager.simulador.custoLimao.ToString() + ";"
							+ GameManager.simulador.custoPessego.ToString() + ";"
							+ GameManager.simulador.custoTamarindo.ToString() + ";"
							+ GameManager.simulador.custoUva.ToString() + ";"
							+ GameManager.simulador.custoCopo.ToString() + ";"
							+ GameManager.simulador.custoGelo.ToString() + ";"
							+ GameManager.simulador.custoTotal.ToString() + ";"
							+ GameManager.simulador.custoSucoLaranja.ToString() + ";"
							+ GameManager.simulador.custoSucoLimao.ToString() + ";"
							+ GameManager.simulador.custoSucoPessego.ToString() + ";"
							+ GameManager.simulador.custoSucoTamarindo.ToString() + ";"
							+ GameManager.simulador.custoSucoUva.ToString() + ";"
							+ GameManager.simulador.lucroLaranja.ToString() + ";"
							+ GameManager.simulador.lucroLimao.ToString() + ";"
							+ GameManager.simulador.lucroPessego.ToString() + ";"
							+ GameManager.simulador.lucroTamarindo.ToString() + ";"
							+ GameManager.simulador.lucroUva.ToString() + ";"
							+ GameManager.simulador.lucroTotal.ToString();
		GameManager.simulador.salvar(salvarDado);
	}
	
}
