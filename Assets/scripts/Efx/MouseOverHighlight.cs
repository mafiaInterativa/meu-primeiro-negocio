using UnityEngine;
using System.Collections;

public class MouseOverHighlight : MonoBehaviour {
	private Renderer[] renderers;
	private Color[] originalColors;
	private Color tintOver = new Color(0.1f,0.1f,0.1f);

	private bool StatusHud;

	// Use this for initialization
	void Start () {
		StatusHud = false;
		renderers = GetComponentsInChildren<Renderer>();
		originalColors = new Color[renderers.Length];
		for(int i = 0; i < renderers.Length; i ++){
			if(renderers[i].material.shader.name == "Diffuse")
				originalColors[i] = renderers[i].material.color;
		}
	}

	// Update is called once per frame
	void Update () {
		if(GameManager.simulador.getStatusHud() && !StatusHud ){
			for(int i = 0; i < renderers.Length; i ++){
				if(renderers[i].material.shader.name == "Diffuse")
					renderers[i].material.color = originalColors[i];
				StatusHud = true;
			}
		}

	}

	void OnMouseOver(){
		if(!GameManager.simulador.getStatusHud()){
			for(int i = 0; i < renderers.Length; i ++){
				if(renderers[i].material.shader.name == "Diffuse")
					renderers[i].material.color = originalColors[i] + tintOver;
			}
		}

	}

	void OnMouseExit(){
		if(!GameManager.simulador.getStatusHud()){
			for(int i = 0; i < renderers.Length; i ++){
				if(renderers[i].material.shader.name == "Diffuse")
					renderers[i].material.color = originalColors[i];
				StatusHud = false;
			}
		}
	}
}
