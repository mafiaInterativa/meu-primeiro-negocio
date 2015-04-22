using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConfirmacaoHudControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */
	
	public Button btnOk;
	public Button btnCancel;	
	public Text lblMsg;

	private GameObject cameraObject;
	private CameraControl cameraControl;

	private LocalControl myLocal;
	
	/*
	 *  Sistema
	 */
	
	void Start () {
		//oculta hud
		gameObject.SetActive(false);

		//listner
		btnOk.onClick.AddListener(() => { gerarFeedBack(true); });
		btnCancel.onClick.AddListener(() => { gerarFeedBack(false); });

		//aviso
		cameraObject = GameObject.FindWithTag ("MainCamera");
		cameraControl = cameraObject.GetComponent<CameraControl> ();
	}
	
	
	void Update () {
		
	}
	
	/*
	 *  Game
	 */	
	
	public void exibir(string mensagem, LocalControl local) {
		myLocal = local;
		
		cameraControl.setMovimentacao(false);
		GameManager.simulador.setStatusHud(true);
		gameObject.SetActive(true);
		
		lblMsg.text = mensagem;

		audio.Play ();
	}
	
	public void ocultar() {
		gameObject.SetActive(false);
		cameraControl.setMovimentacao(true);
		GameManager.simulador.setStatusHud(false);
	}

	public void gerarFeedBack(bool status){
		if(status == true){
			//LocalControl lc = myLocal.GetComponent<LocalControl> ();
			//lc.EfetuarCompra();
			myLocal.EfetuarCompra();
		}
		
		this.ocultar();
	}

}
