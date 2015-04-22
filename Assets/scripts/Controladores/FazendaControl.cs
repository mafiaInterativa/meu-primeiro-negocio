using UnityEngine;
using System.Collections;

public class FazendaControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */
	
	public GameObject hud;
	private bool exibirHud = false;
	
	private GameObject cameraObject;
	private CameraControl cameraControl;
	
	/*
	 *  Sistema
	 */
	
	void Start () {
		cameraObject = GameObject.FindWithTag ("MainCamera");
		cameraControl = cameraObject.GetComponent<CameraControl> ();
	}
	
	void Update () {
		if(exibirHud && cameraControl.lerpControl == false){	
			//exibe a hud
			ComprasHudControl hudControl = hud.GetComponent<ComprasHudControl>();
			hudControl.exibir();
			
			exibirHud = false;
		}
	}
	
	void OnMouseDown () {
		if( GameManager.simulador.getStatusHud() == false && cameraControl.lerpControl == false ){
			//fixar camera no objeto
			cameraControl.travarCamera (this.transform.position.x, this.transform.position.y, this.transform.position.z);
			
			exibirHud = true;
		}
	}

}
