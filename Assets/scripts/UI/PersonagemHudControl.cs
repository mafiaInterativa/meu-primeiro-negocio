using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PersonagemHudControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

	public PersonagemControl personagemControl;
	public Image frutaPreferida;
	public Image barraSatisfacao;
	public Image barraSede;
	public Image barraPressa;

	public Sprite LaranjaImg;
	public Sprite LimaoImg;
	public Sprite PessegoImg;
	public Sprite TamarindoImg;
	public Sprite UvaImg;

	public float timeToDestroy;
	private float currentTimeToDestroy;

	/*
	 *  Sistema
	 */

	void Start () {
		currentTimeToDestroy = 0;
		alimentaHud();
	}
	
	/*
	 *  Game
	 */

	void Update () {
		if(Input.GetKeyDown(KeyCode.KeypadEnter)){
			print("Size " + barraSede.rectTransform.sizeDelta.x);
			print("AP " + barraSede.rectTransform.anchoredPosition.x);
		}

		if(currentTimeToDestroy >= timeToDestroy)
			Destroy(gameObject);
		currentTimeToDestroy += Time.deltaTime;
		transform.position = personagemControl.transform.position + new Vector3 (0, 2, 0);
		transform.rotation = Camera.main.transform.rotation;
	}

	void alimentaHud(){
		barraSede.rectTransform.sizeDelta = new Vector2( -300 + (personagemControl.sede * 2.8f) , barraSede.rectTransform.sizeDelta.y);
		barraSede.rectTransform.anchoredPosition = new Vector2( -140 + (personagemControl.sede * 1.4f) , barraSede.rectTransform.anchoredPosition.y);

		barraSatisfacao.rectTransform.sizeDelta = new Vector2( -300 + (personagemControl.satisfacao * 2.8f) , barraSatisfacao.rectTransform.sizeDelta.y);
		barraSatisfacao.rectTransform.anchoredPosition = new Vector2( -140 + (personagemControl.satisfacao * 1.4f) , barraSatisfacao.rectTransform.anchoredPosition.y);

		barraPressa.rectTransform.sizeDelta = new Vector2( -300 + (personagemControl.pressa * 2.8f) , barraPressa.rectTransform.sizeDelta.y);
		barraPressa.rectTransform.anchoredPosition = new Vector2( -140 + (personagemControl.pressa * 1.4f) , barraPressa.rectTransform.anchoredPosition.y);

		if(personagemControl.sucoFavorito == "LARANJA"){
			frutaPreferida.sprite = LaranjaImg;
		}
		if(personagemControl.sucoFavorito == "LIMÃO"){
			frutaPreferida.sprite = LimaoImg;
		}
		if(personagemControl.sucoFavorito == "PÊSSEGO"){
			frutaPreferida.sprite = PessegoImg;
		}
		if(personagemControl.sucoFavorito == "TAMARINDO"){
			frutaPreferida.sprite = TamarindoImg;
		}
		if(personagemControl.sucoFavorito == "UVA"){
			frutaPreferida.sprite = UvaImg;
		}
	}

}
