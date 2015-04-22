using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialHudControl : MonoBehaviour {
	
	/*
	 *  VARIAVEIS
	 */
	public Button btnClose;

	public Button btnNext;
	public Text lblBtnNext;

	public Button btnPrev;
	public Text lblBtnPrev;

	public GameObject janela01;
	public GameObject janela02;
	public GameObject janela03;
	public GameObject janela04;
	public GameObject janela05;
	public GameObject janela06;
	public GameObject janela07;
	public GameObject janela08;

	private GameObject cameraObject;
	private CameraControl cameraControl;

	private int janelaAtual = 1;
	public bool estado = false;
	
	/*
	 *  Sistema
	 */

	void Start () {
		gameObject.SetActive(false);
	}
	

	void Update () {
	
	}

	/*
	 *  Game
	 */	

	public void exibir(){
		//camera
		cameraObject = GameObject.FindWithTag ("MainCamera");
		cameraControl = cameraObject.GetComponent<CameraControl> ();
		
		cameraControl.setMovimentacao(false);
		GameManager.simulador.setStatusHud(true);
		gameObject.SetActive(true);
		
		estado = false;
		
		//listner
		btnNext.onClick.AddListener(() => { exibirJanela( "+" ); });
		btnPrev.onClick.AddListener(() => { exibirJanela( "-" ); });
		
		btnClose.onClick.AddListener(() => { ocultar(); });
		
		//inicia primeira tela
		this.exibirJanela();
	}

	private void exibirJanela( string operador = null ){	
		if(operador == "+" && janelaAtual < 9){
			janelaAtual++;
		}

		if(operador == "-" && janelaAtual > 0){
			janelaAtual--;
		}

		if(janelaAtual > 0 && janelaAtual <= 9){
			this.ocultarJanelas();
			
			if(janelaAtual == 1){
				janela01.SetActive(true);
				btnPrev.interactable = false;
			} else

			if(janelaAtual == 2){
				janela02.SetActive(true);
			} else

			if(janelaAtual == 3){
				janela03.SetActive(true);
			} else

			if(janelaAtual == 4){
				janela04.SetActive(true);
			} else

			if(janelaAtual == 5){
				janela05.SetActive(true);
			} else

			if(janelaAtual == 6){
				janela06.SetActive(true);
			} else

			if(janelaAtual == 7){
				janela07.SetActive(true);
			} else

			if(janelaAtual == 8){
				janela08.SetActive(true);
				lblBtnNext.text = "Jogar";
			}

			if(janelaAtual == 9){
				ocultar();
			}
		}
	}

	private void ocultarJanelas(){
		audio.Play ();

		btnPrev.interactable = true;
		btnNext.interactable = true;

		lblBtnPrev.text = "Anterior";
		lblBtnNext.text = "Próximo";	

		janela01.SetActive(false);
		janela02.SetActive(false);
		janela03.SetActive(false);
		janela04.SetActive(false);
		janela05.SetActive(false);
		janela06.SetActive(false);
		janela07.SetActive(false);
		janela08.SetActive(false);
	}

	public void ocultar() {
		cameraControl.setMovimentacao(true);
		GameManager.simulador.setStatusHud(false);
		
		estado = true;
		
		gameObject.SetActive(false);
	}
}
