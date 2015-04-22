using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverHudControl : MonoBehaviour {
	
	/*
	 *  VARIAVEIS
	 */
	
	public Button btnClose;
	public Button btnTwitter;
	public Button btnFacebook;
	
	private GameObject cameraObject;
	private CameraControl cameraControl;
	
	/*
	 *  Sistema
	 */
	
	void Start () {
		//oculta hud
		gameObject.SetActive(false);
		
		//listner
		btnClose.onClick.AddListener(() => { ocultar(); });
		btnClose.onClick.AddListener(() => { ocultar(); });
		btnClose.onClick.AddListener(() => { ocultar(); });
		
		//aviso
		cameraObject = GameObject.FindWithTag ("MainCamera");
		cameraControl = cameraObject.GetComponent<CameraControl> ();
	}
	
	
	void Update () {
		
	}
	
	/*
	 *  Game
	 */	
	
	public void exibir() {
		cameraControl.setMovimentacao(false);
		GameManager.simulador.setStatusHud(true);
		gameObject.SetActive(true);
		
		audio.Play ();
	}
	
	public void ocultar() {
		Application.LoadLevel ("level1"); 
	}

	public void acessarTwitter(){
		Application.OpenURL("http://twitter.com/home?status=Minha pontuaçao no jogo: Meu Primeiro Negócio - Tenda de Sucos foi de: "+GameManager.simulador.getOrcamento()+" (Desafio Sebrae)");
	}

	public void acessarFacebook(){
		Application.OpenURL("https://www.facebook.com/sharer/sharer.php?u=Minha pontuaçao no jogo: Meu Primeiro Negócio - Tenda de Sucos foi de: "+GameManager.simulador.getOrcamento()+" (Desafio Sebrae)");
	}
}