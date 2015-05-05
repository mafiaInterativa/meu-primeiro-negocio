using UnityEngine;
using System.Collections;

public class ProcessadorControl : MonoBehaviour {

	public GameObject copo;
	public GameObject gelo;
	public GameObject manivela;
	public GameObject laranja;
	public GameObject limao;
	public GameObject pessego;
	public GameObject tamarindo;
	public GameObject uva;

	public AudioClip copoSound;
	public AudioClip geloSound;
	public AudioClip frutaSound;
	public AudioClip sucoSound;

	public ParticleSystem sucoParticula;

	public Color corLaranja;
	public Color corLimao;
	public Color corPessego;
	public Color corTamarindo;
	public Color corUva;
		
	public bool timerProcessaSuco;
	public float tempoSuco;
	private float currentTempoSuco;

	// Use this for initialization
	void Start () {
		gelo.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(timerProcessaSuco){
			currentTempoSuco += Time.deltaTime;
			if(currentTempoSuco > tempoSuco){
				LimpaCopoGelo();
				timerProcessaSuco = false;
			}
				
		}
	}

	public bool ProcessaSuco(){
		if (!animation.isPlaying){
			animation.Play("ProcessadorManivelaAnim");
			sucoParticula.Play();
		
			LimpaFrutas();
			currentTempoSuco = 0;
			timerProcessaSuco = true;
			
			//som
			audio.clip = sucoSound;
			audio.Play ();

			return true;
		} else {
			return false;
		}
	}

	public bool ColocarCopo(){
		if (!animation.isPlaying){
			animation.Play("ProcessadorCopoAnim");
		
			//som
			audio.clip = copoSound;
			audio.Play ();

			return true;
		} else {
			return false;
		}
	}

	public bool ColocarGelo(){
		if (!animation.isPlaying){
			gelo.SetActive(true);

			animation.Play("ProcessadorGeloAnim");
		
			//som
			audio.clip = geloSound;
			audio.Play ();

			return true;
		} else {
			return false;
		}
	}

	public bool ColocarLaranja(){
		if (!animation.isPlaying){
			LimpaFrutas();
			laranja.SetActive(true);

			sucoParticula.startColor = corLaranja;

			animation.Play("ProcessadorFrutasAnim");
		
			//som
			audio.clip = frutaSound;
			audio.Play ();

			return true;
		} else {
			return false;
		}
	}
	public bool ColocarLimao(){
		if (!animation.isPlaying){
			LimpaFrutas();
			limao.SetActive(true);
			
			sucoParticula.startColor = corLimao;

			animation.Play("ProcessadorFrutasAnim");
		
			//som
			audio.clip = frutaSound;
			audio.Play ();

			return true;
		} else {
			return false;
		}
	}
	public bool ColocarPessego(){
		if (!animation.isPlaying){
			LimpaFrutas();
			pessego.SetActive(true);
			
			sucoParticula.startColor = corPessego;

			animation.Play("ProcessadorFrutasAnim");
		
			//som
			audio.clip = frutaSound;
			audio.Play ();

			return true;
		} else {
			return false;
		}
	}
	public bool ColocarTamarindo(){
		if (!animation.isPlaying){
			LimpaFrutas();
			tamarindo.SetActive(true);
		
			sucoParticula.startColor = corTamarindo;

			animation.Play("ProcessadorFrutasAnim");
		
			//som
			audio.clip = frutaSound;
			audio.Play ();

			return true;
		} else {
			return false;
		}
	}
	public bool ColocarUva(){
		if (!animation.isPlaying){
			LimpaFrutas();
			uva.SetActive(true);

			sucoParticula.startColor = corUva;

			animation.Play("ProcessadorFrutasAnim");
		
			//som
			audio.clip = frutaSound;
			audio.Play ();

			return true;
		} else {
			return false;
		}
	}

	public void LimpaFrutas(){
		laranja.SetActive(false);
		limao.SetActive(false);
		pessego.SetActive(false);
		tamarindo.SetActive(false);
		uva.SetActive(false);
	}

	public void LimpaCopoGelo(){
		copo.SetActive(false);
		gelo.SetActive(false);
	}
}
