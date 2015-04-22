using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuHudControl : MonoBehaviour {
	
	/*
	 *  VARIAVEIS
	 */
	
	private GameObject cameraObject;
	private CameraControl cameraControl;

	public GameObject hudTutorial;
	
	public Button btnJogar;
	public Button btnCarregar;
	public Button btnOpcoes;
	public Button btnSobre;

	public GameObject janelaMenu;
	public GameObject janelaOpcoes;
	public GameObject janelaSobre;

	public Button btnVoltarOpcoes;
	public Button btnVoltarSobre;

	/*
	 *  Sistema
	 */
	
	void Start () {
		//camera
		cameraObject = GameObject.FindWithTag ("MainCamera");
		cameraControl = cameraObject.GetComponent<CameraControl> ();
		
		cameraControl.setMovimentacao(false);
		GameManager.simulador.setStatusHud(true);
		gameObject.SetActive(true);

		//listner
		btnJogar.onClick.AddListener(() => { jogar (); });
		btnOpcoes.onClick.AddListener(() => { alterarJanela ("opcoes"); });
		btnSobre.onClick.AddListener(() => { alterarJanela ("sobre"); });

		btnVoltarOpcoes.onClick.AddListener(() => { alterarJanela ("main"); });
		btnVoltarSobre.onClick.AddListener(() => { alterarJanela ("main"); });

		//load
		string dataSaved = PlayerPrefs.GetString(GameManager.simulador.flagSave);

		if(dataSaved != ""){
			btnCarregar.interactable = true;
			btnCarregar.onClick.AddListener(() => { cameraObject.GetComponent<GameManager> ().carregarGame(); jogar (); });
		} else {
			btnCarregar.interactable = false;
		}
	}
	
	
	void Update () {
		
	}
	
	/*
	 *  Game
	 */	

	public void alterarJanela(string janela){
		janelaMenu.SetActive(false);
		janelaOpcoes.SetActive(false);
		janelaSobre.SetActive(false);

		if(janela == "main"){
			janelaMenu.SetActive(true);
		}

		if(janela == "opcoes"){
			janelaOpcoes.SetActive(true);
		}

		if(janela == "sobre"){
			janelaSobre.SetActive(true);
		}
	}

	public void jogar(){
		ocultar();

		cameraControl.cameraGame();
		TutorialHudControl htc = hudTutorial.GetComponent<TutorialHudControl> ();
		htc.exibir();
	}
	
	public void ocultar() {
		cameraControl.setMovimentacao(true);
		GameManager.simulador.setStatusHud(false);
		
		gameObject.SetActive(false);
	}
}
