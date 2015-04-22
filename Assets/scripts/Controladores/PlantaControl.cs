using UnityEngine;
using System.Collections;

public class PlantaControl : MonoBehaviour {

	public Color plantaCor;

	// Use this for initialization
	void Start () {
		plantaCor = new Color( 0.05882f + (Random.value * 0.5f), 0.4274f , 0.0784f );
		renderer.material.color = plantaCor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
