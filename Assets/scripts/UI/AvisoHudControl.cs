using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AvisoHudControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

	public Button btnOk;
	public Text lblMsg;

	private GameObject cameraObject;
	private CameraControl cameraControl;

	public bool estado = false;

	/*
	 *  Sistema
	 */

	void Start () {
		//oculta hud
		gameObject.SetActive(false);
	
		//listner
		btnOk.onClick.AddListener(() => { ocultar(); });

		//aviso
		//cameraObject = GameObject.FindWithTag ("MainCamera");
		//cameraControl = cameraObject.GetComponent<CameraControl> ();

		//estado = false;
	}


	void Update () {
	
	}

	/*
	 *  Game
	 */	

	public void exibir(string mensagem) {
		//cameraControl.setMovimentacao(false);
		//GameManager.simulador.setStatusHud(true);
		gameObject.SetActive(true);

		lblMsg.text = mensagem;

		audio.Play ();
	}
	
	public void ocultar() {
		//cameraControl.setMovimentacao(true);
		//GameManager.simulador.setStatusHud(false);
		
		//estado = true;

		gameObject.SetActive(false);
	}
}
