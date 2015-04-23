using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PersonagemHudPensamentoControl : MonoBehaviour {
	
	/*
	 *  VARIAVEIS
	 */
	
	public PersonagemControl personagemControl;
	private GameObject cameraObject;
	private CameraControl cameraControl;

	public bool exibindoPensamento = true;

	public Image sucoFavoritoImg;

	public Sprite LaranjaImg;
	public Sprite LimaoImg;
	public Sprite PessegoImg;
	public Sprite TamarindoImg;
	public Sprite UvaImg;

	/*
	 *  Sistema
	 */
	
	void Start () {
		//oculta hud
			//gameObject.SetActive(false);
	}
	
	
	void Update () {
		//pos balao
			transform.position = personagemControl.transform.position + new Vector3 (0, 0.825f, 0);
			transform.rotation = Camera.main.transform.rotation;
	}
	
	/*
	 *  Game
	 */	
	
	public void exibir() {
		if( GameManager.simulador.statusHud == false && GameManager.simulador.statusVenda == false ){
			gameObject.SetActive(true);
	
			exibeSucoFavorito(personagemControl.sucoFavorito);

			Invoke("ocultar", 4);
		} else {
			this.exibindoPensamento = true;
		}
	}

	public void ocultar() {
		gameObject.SetActive(false);

		this.exibindoPensamento = true;
	}

	public void exibeSucoFavorito(string sucoDesejado){
		if(sucoDesejado == "LARANJA"){
			sucoFavoritoImg.sprite = LaranjaImg;
		}
		if(sucoDesejado == "LIMÃO"){
			sucoFavoritoImg.sprite = LimaoImg;
		}
		if(sucoDesejado == "PÊSSEGO"){
			sucoFavoritoImg.sprite = PessegoImg;
		}
		if(sucoDesejado == "TAMARINDO"){
			sucoFavoritoImg.sprite = TamarindoImg;
		}
		if(sucoDesejado == "UVA"){
			sucoFavoritoImg.sprite = UvaImg;
		}
	}
}