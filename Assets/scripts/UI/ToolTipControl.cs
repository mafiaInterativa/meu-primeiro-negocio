using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToolTipControl : MonoBehaviour {
	
	public Text lblValor;
	
	// Use this for initialization
	void Start () {
		ocultar();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void ocultar(){
		gameObject.SetActive(false);
	}
	
	public void exibir(int valor){
		if(valor == 1){
			lblValor.text = "Preço Suco: $" + GameManager.simulador.prcSucoLaranja;
		}

		else if(valor == 2){
			lblValor.text = "Preço Suco: $" + GameManager.simulador.prcSucoLimao;
		}

		else if(valor == 3){
			lblValor.text = "Preço Suco: $" + GameManager.simulador.prcSucoPessego;
		}

		else if(valor == 4){
			lblValor.text = "Preço Suco: $" + GameManager.simulador.prcSucoTamarindo;
		}

		else if(valor == 5){
			lblValor.text = "Preço Suco: $" + GameManager.simulador.prcSucoUva;
		}

		gameObject.SetActive(true);
	}

	public void posicionar(GameObject gObj){

		gameObject.transform.position = new Vector3(gObj.transform.position.x-130, gObj.transform.position.y, gObj.transform.position.z) ;
	}
}
