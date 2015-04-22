using UnityEngine;
using System.Collections;

public class RodaControl : MonoBehaviour {
	public float speed;
	public bool mudaSentido;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (!mudaSentido){
			transform.Rotate(speed * 10 * Time.deltaTime,0,0);
		} else {
			transform.Rotate(-speed * 10 * Time.deltaTime,0,0);
		}
			
	}
}
