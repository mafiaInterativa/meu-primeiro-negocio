using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DicasHudControl : MonoBehaviour {
	
	/*
	 *  VARIAVEIS
	 */

	public Text lblDica;
	public bool exibindoDica = true;
	
	private GameObject cameraObject;
	private CameraControl cameraControl;

	private string[] dicas = new string[5];
	
	
	/*
	 *  Sistema
	 */
	
	void Start () {
		//oculta hud
			gameObject.SetActive(false);

		//define dicas
			this.dicas[0] = "Faça uma pesquisa de mercado clicando nas pessoas.";
			this.dicas[1] = "Lembre-se, há diferença de valores entre um fornecedor e outro.";
			this.dicas[2] = "Copos e Gelo estão disponíveis apenas no Mercado.";
			this.dicas[3] = "Coloque gelo nos seus sucos para aumentar a satisfação de seus clientes.";
			this.dicas[4] = "Não abuse do valor de venda de seu suco.";			
	}
	
	
	void Update () {
		
	}
	
	/*
	 *  Game
	 */	
	
	public void exibir() {
		if( GameManager.simulador.statusHud == false && GameManager.simulador.statusVenda == false ){
			gameObject.SetActive(true);
	
			lblDica.text = this.getDica();
			
			audio.Play ();
			
			Invoke("ocultar", 10);
		} else {
			this.exibindoDica = true;
		}
	}

	public void ocultar() {
		gameObject.SetActive(false);

		this.exibindoDica = true;
	}

	private string getDica(){
		return dicas[Random.Range(0,4)];
	}
}