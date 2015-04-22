using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelOpcoes : MonoBehaviour {

	/*
	 *  VARIAVEIS
	 */

	public Button opc01;
	public Button opc02;
	public Button opc03;
	
	/*
	 *  Sistema
	 */

	void Start () {
		opc01.onClick.AddListener(() => { alterarQualidade (1); });
		opc02.onClick.AddListener(() => { alterarQualidade (2); });
		opc03.onClick.AddListener(() => { alterarQualidade (3); });
	}
	
	void Update () {
	
	}

	/*
	 *  Game
	 */	

	public void alterarQualidade(float lv){
		if(lv == 1){
			QualitySettings.currentLevel = QualityLevel.Fastest;
		} else

		if(lv == 2){
			QualitySettings.currentLevel = QualityLevel.Good;
		} else

		if(lv == 3){
			QualitySettings.currentLevel = QualityLevel.Fantastic;
		} 
	}
}
