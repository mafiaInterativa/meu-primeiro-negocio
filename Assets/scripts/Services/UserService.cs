using UnityEngine;
using System.Collections;
using System.Text;

public class UserService : MonoBehaviour {
	
	public string userName;
	public string userEmail;
	public string urlServidor;

	private int highscore;

	public void Awake() {
		Application.ExternalCall("enviarDadosJogo", "Login Service");
	}

	/*Método invocado pela plataforma*/
		public void SetUserData(string info) {
			string[] dados = info.Split(';');
			
			userName = dados[0]; GameManager.simulador.nomeUsuario = dados[0];
			userEmail = dados[1]; GameManager.simulador.emailUsuario = dados[1]; GameManager.simulador.flagSave = dados[1];
			urlServidor = dados[2];
		}

	/*Utilizar este método para configurar a varíavel highscore a ser enviada para a plataforma*/
		public void SetHighScore(int score){
			highscore = score;
		}
	
	/*Utilizar este método para iniciar a chamada ao WebService*/
		public void CallSendScore(){
			StartCoroutine("sendScore");
		}
	
		public IEnumerator sendScore() {
			string json = 	"{\"gameName\": \"meu_primeiro_negocio\", \"highscore\":"+ highscore + ", \"metaData\": \""+PlayerPrefs.GetString(GameManager.simulador.flagSave)+"\", \"user\": {\"userName\":\"" + userName + "\", \"userEmail\": \"" + userEmail + "\"} }";
			Hashtable hash = new Hashtable();
			
			hash["Content-Type"] = "application/json";
			
			byte[] pData = Encoding.ASCII.GetBytes(json.ToCharArray());
			WWW w = new WWW(urlServidor + "/rest/game/sendhighscore", pData, hash);
	
			while (!w.isDone) {
				yield return null;
			}
	
			if (w.error != null || w.text != null) {
				Application.ExternalCall("sendScoreCallback", w.error != null ? w.error : w.text);
			}
	
			Debug.Log(w.error);
		}
}