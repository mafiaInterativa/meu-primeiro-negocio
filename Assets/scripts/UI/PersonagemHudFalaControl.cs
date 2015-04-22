using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PersonagemHudFalaControl : MonoBehaviour {
	
	/*
	 *  VARIAVEIS
	 */
	
	public PersonagemControl personagemControl;

	public Image sucoDesejadoImg;

	public Sprite LaranjaImg;
	public Sprite LimaoImg;
	public Sprite PessegoImg;
	public Sprite TamarindoImg;
	public Sprite UvaImg;

	public Sprite SatisfeitoImg;
	public Sprite InsatisfeitoImg;

	public float timeToDestroy;
	private float currentTimeToDestroy;

	public AudioClip soundBalao;

	/*
	 *  Sistema
	 */

	void Start () {
		currentTimeToDestroy = 0;

		//som
		audio.clip = soundBalao;
		audio.Play ();
	}

	void Update () {
		if(currentTimeToDestroy >= timeToDestroy)
			Destroy(gameObject);
		currentTimeToDestroy += Time.deltaTime;

		transform.position = personagemControl.transform.position + new Vector3 (0, 0.825f, 0);
		transform.rotation = Camera.main.transform.rotation;
	}

	/*
	 *  Game
	 */

	public void exibeSucoDesejado(string sucoDesejado){

		if(sucoDesejado == "LARANJA"){
			sucoDesejadoImg.sprite = LaranjaImg;
		}
		if(sucoDesejado == "LIMÃO"){
			sucoDesejadoImg.sprite = LimaoImg;
		}
		if(sucoDesejado == "PÊSSEGO"){
			sucoDesejadoImg.sprite = PessegoImg;
		}
		if(sucoDesejado == "TAMARINDO"){
			sucoDesejadoImg.sprite = TamarindoImg;
		}
		if(sucoDesejado == "UVA"){
			sucoDesejadoImg.sprite = UvaImg;
		}
	}

	public void exibeSentimento(string sentimento){
		if(sentimento == "satisfeito"){
			sucoDesejadoImg.sprite = SatisfeitoImg;
		}

		if(sentimento == "insatisfeito"){
			sucoDesejadoImg.sprite = InsatisfeitoImg;
		}
	}

}
