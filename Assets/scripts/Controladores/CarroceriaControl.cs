using UnityEngine;
using System.Collections;

public class CarroceriaControl : MonoBehaviour {

	public float min;
	public float max;
	private float startY;
	// Use this for initialization
	void Start () {
		startY = 0.28f;
	}
	
	// Update is called once per frame
	void Update () {
		float randomY = startY + Random.Range(min, max);
		
		if(Time.deltaTime > 0.0f){
			transform.position = new Vector3(transform.position.x , randomY , transform.position.z);
		}
	}
}
