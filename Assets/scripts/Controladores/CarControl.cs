using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour {
	
	/*
	 *  VARIAVEIS
	 */
	
	private Vector3 direcao = new Vector3(0,0,1);
	private Quaternion target;

	public float velocidade = 1;
	public float rayArea = 1;
	public float ang;
	//private string flagDir = "";
	private float velocidadeTemp;
	public bool[] direcoes;
	public bool esquerda, frente, direita;

	public bool virando;

	private bool carroParado;
	private float velocidadeRotacao;
	/*
	 *  Sistema
	 */

	void Start () {
		velocidadeTemp = velocidade;
		virando = false;
		velocidadeRotacao = 1;
		carroParado = false;
	}

	void FixedUpdate () {
		Ray ray = new Ray (transform.position, transform.TransformDirection(direcao));
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, rayArea)) {

			if(hit.collider.tag == "Waypoint" && !virando){
				AlinharCarro(hit);
				esquerda = hit.collider.GetComponent<WaypointControl>().Esquerda;
				frente = hit.collider.GetComponent<WaypointControl>().Frente;
				direita = hit.collider.GetComponent<WaypointControl>().Direita;


				// Esquerda + Frente + Direita
				if(esquerda && frente && direita){

					int randomValue = Random.Range(1,4);
					if(randomValue == 1){
						ViraEsquerda();
					}
					if(randomValue == 2){
						ViraDireita();
					}
					if(randomValue == 3){
						SegueEmFrente();
					}

				}

				// Esquerda + Frente
				if(esquerda && frente && !direita){
					int randomValue = Random.Range(1,3);
					if(randomValue == 1){
						ViraEsquerda();
					}
					if(randomValue == 2){
						SegueEmFrente();
					}
				}

				// Esquerda + Direita
				if(esquerda && !frente && direita){
					int randomValue = Random.Range(1,3);
					if(randomValue == 1){
						ViraEsquerda();
					}
					if(randomValue == 2){
						ViraDireita();
					}
				}

				// Frente + Direita
				if(!esquerda && frente && direita){
					int randomValue = Random.Range(1,3);
					if(randomValue == 1){
						SegueEmFrente();
					}
					if(randomValue == 2){
						ViraDireita();
					}
				}

				// Esquerda
				if(esquerda && !frente && !direita){
					ViraEsquerda();
				}

				// Frente
				if(!esquerda && frente && !direita){
					SegueEmFrente();
				}

				//Direita
				if(!esquerda && !frente && direita){
					ViraDireita();
				}





			}




			/*
			if(flagDir == "" && hit.collider.gameObject.name == "Point"){

				GameObject pointObject = hit.collider.gameObject;
				PointControl point = pointObject.GetComponent<PointControl> ();




				if (point.direcao == "R" && flagDir != "R") {
					flagDir = "R";
					target = Quaternion.Euler (0, 90+ang, 0);
				}

				if (point.direcao == "L" && flagDir != "L") {
					flagDir = "L";
					target = Quaternion.Euler (0, -90+ang, 0);
				}

				if (point.direcao == "RC" && flagDir != "RC") {
					flagDir = "RC";

					int r = Random.Range (1, 2);

					if (r == 1) {
						target = Quaternion.Euler (0, 90+ang, 0);
					} 
				}

				if (point.direcao == "LC" && flagDir != "LC") {
					flagDir = "LC";

					int r = Random.Range (1, 2);

					if (r == 1) {
						target = Quaternion.Euler (0, -90+ang, 0);
					} 
				}

			}
			*/
			if (hit.collider.gameObject.tag == "Carro" && !carroParado) {
				print("Bateu");
				velocidade = 0;
				carroParado = true;
				Invoke("RetomaVelocidade", 2);

			} 
			/*
			if (hit.collider.gameObject.tag == "Terreno") {
				GameObject spaw = GameObject.Find ("Spaw");
				Instantiate( this, spaw.transform.position, spaw.transform.rotation);

				Destroy(gameObject);
			}
			*/

		}

		//debug
		Vector3 forward = transform.TransformDirection(direcao) * rayArea;
		Debug.DrawRay(transform.position, forward, Color.green);

		//movimento
		this.transform.Translate(direcao * Time.deltaTime * velocidade);




			//Debug.Log (Vector3.Angle (transform.rotation.eulerAngles, target.eulerAngles));
		this.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * velocidadeRotacao);


		//Debug.Log("Y= " + transform.rotation.eulerAngles.y + " Target= " + target.eulerAngles.y + " Dif= " + (transform.rotation.eulerAngles.y - target.eulerAngles.y));
	}


	void ViraEsquerda(){
		Invoke("VirandoFalse", 2);
		ang = transform.rotation.eulerAngles.y;
		velocidadeRotacao = 1f;
		target = Quaternion.Euler (0, -90 +ang, 0);
		//print ("Esquerda");
		virando = true;
	}

	void SegueEmFrente(){
		Invoke("VirandoFalse", 2);

		//print ("Frente");
		virando = true;
	}

	void ViraDireita(){
		Invoke("VirandoFalse", 2);
		velocidadeRotacao = 2f;
		if( transform.rotation.eulerAngles.y > 340){
			target = Quaternion.Euler (0, 90, 0);
		} else {
			target = Quaternion.Euler (0, transform.rotation.eulerAngles.y + 90, 0);
		}
		virando = true;
		//print ("Direita");
	}

	void VirandoFalse(){
		virando = false;
	}

	void AlinharCarro(RaycastHit hit){
		float AnguloAtual = transform.rotation.eulerAngles.y;


		if( Mathf.Abs(AnguloAtual - 270) < 10 ){
			transform.position = new Vector3( transform.position.x, transform.position.y, hit.collider.transform.position.z);
			transform.rotation = Quaternion.Euler(0, 270, 0);
		}
			

		if( Mathf.Abs(AnguloAtual - 90) < 10 ){
			transform.position = new Vector3( transform.position.x, transform.position.y, hit.collider.transform.position.z);
			transform.rotation = Quaternion.Euler(0, 90, 0);
		}
			

		if( Mathf.Abs(AnguloAtual) < 10 ){
			transform.position = new Vector3( hit.collider.transform.position.x, transform.position.y, transform.transform.position.z);
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
			

		if( Mathf.Abs(AnguloAtual - 180) < 10 ){
			transform.rotation = Quaternion.Euler(0, 180, 0);
			transform.position = new Vector3( hit.collider.transform.position.x, transform.position.y, transform.transform.position.z);
		}
			
	}

	void RetomaVelocidade(){
		velocidade = velocidadeTemp;
		carroParado = false;
	}

	// Alinhamentos




}
