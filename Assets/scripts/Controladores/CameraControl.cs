using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */
		
	//move control
		public int LevelArea = 50;
		public int ScrollArea = 40;
		public int ScrollSpeed = 10;

	//manager control
		private bool movimentacao = true;
		public bool lerpControl = false;

	//lerp
		private Vector3 posicaoAtual;
		private Vector3 posicaoFinal;

		private Quaternion rotacaoAtual;
		private Quaternion rotacaoFinal;

		private float smooth = 3f;
		public bool LerpMov = false;

	//main hud
		GameObject mainHud;
		MainHudControl mainHudControl;

	/*
	 *  Sistema
	 */

	void Start () {
		//main hud
	 	mainHud = GameObject.Find ("MainHud");
		mainHudControl = mainHud.GetComponent<MainHudControl> ();

		//fix camera start
		this.cameraMenu();
	}

	void Update()
	{
		if (movimentacao) {
			var translation = Vector3.zero;

			//mouse
			if (Input.mousePosition.x > ScrollArea) {
					translation += Vector3.right * -ScrollSpeed * Time.deltaTime;
			}
	
			if (Input.mousePosition.x <= Screen.width - ScrollArea) {
					translation += Vector3.right * ScrollSpeed * Time.deltaTime;
			}
	
			if (Input.mousePosition.y > ScrollArea) {
					translation += Vector3.forward * -ScrollSpeed * Time.deltaTime;
			}
	
			if (Input.mousePosition.y < Screen.height - ScrollArea) {
					translation += Vector3.forward * ScrollSpeed * Time.deltaTime;
			}
	
			//checa area da camera
			var desiredPosition = camera.transform.position + translation;
			if (desiredPosition.x < -LevelArea - 10|| LevelArea < desiredPosition.x + 25) {
					translation.x = 0;
			}
	
			if (desiredPosition.z < -LevelArea + 35|| LevelArea < desiredPosition.z +15) {
					translation.z = 0;
			}
	
			//movimenta a camera
			camera.transform.position += translation;
		}

		if (lerpControl) {
			camera.transform.position = Vector3.Lerp(camera.transform.position, posicaoFinal, smooth * Time.deltaTime);
			camera.transform.rotation = Quaternion.Slerp(camera.transform.rotation, rotacaoFinal, smooth * Time.deltaTime);

			if( Vector3.Distance(camera.transform.position, posicaoFinal) <= 0.01f ){
				this.lerpControl = false;

				//correcao da camera
				camera.transform.position = posicaoFinal;
				camera.transform.rotation = rotacaoFinal;
				
				if(this.LerpMov == true){
					this.movimentacao = true;
					this.LerpMov = false;
				}
			}
		}
	}	

	/*
	 *  Game
	 */
	
	public void cameraGame(){
		camera.transform.position = new Vector3(5f,6f,26f);
		camera.transform.rotation = Quaternion.Euler(40,180,0);

		this.movimentacao = true;
		GameManager.simulador.setStatusHud(false);

		mainHudControl.exibir();
	}

	public void cameraMenu(){
		camera.transform.position = new Vector3(-13f, 2f, 5f);
		camera.transform.rotation = Quaternion.Euler(5,210,0);

		this.movimentacao = false;
		GameManager.simulador.setStatusHud(true);

		mainHudControl.ocultar();
	}


	public  void fixarCamera( float x, float y, float z, float xr, float yr, float zr ){
		this.rotacaoFinal = Quaternion.Euler (camera.transform.rotation.eulerAngles.x+xr, camera.transform.rotation.eulerAngles.y+yr, camera.transform.rotation.eulerAngles.z+zr);
		this.posicaoFinal = new Vector3(x,y,z);

		this.lerpControl = true;
	}

	public  void travarCamera( float x, float y, float z ){		

		if(movimentacao){	
			this.posicaoAtual = camera.transform.position;
			this.rotacaoAtual = camera.transform.rotation;

			this.fixarCamera(x-4, 2, z+5, -25, -75, 0);
		}

		this.movimentacao = false;
	}

	public  void liberarCamera(){
		this.fixarCamera(this.posicaoAtual.x, this.posicaoAtual.y, this.posicaoAtual.z, +25, +75, 0);

		this.LerpMov = true;
	}

	public void setMovimentacao(bool sts){
		this.movimentacao = sts;
	}
}