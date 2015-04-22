using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HudPlacaControl : MonoBehaviour {
	public Text valor;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Camera.main.transform.rotation;
	}

	public void ocultar(){
		gameObject.SetActive(false);
	}

	public void exibir(){
		gameObject.SetActive(true);
	}
}
