using UnityEngine;
using System.Collections;

public class WaypointControl : MonoBehaviour {

	public bool Frente, Direita, Esquerda;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube(transform.position, transform.localScale);
	}

	void ViraDireita(){

	}

	void ViraEsquerda(){

	}
}
