using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DyingScreen : MonoBehaviour {




	//public Button Restart;
	public Button MainMenu;
	private LevelManager levelmanager;

	 //Use this for initialization
	void Start () {

		levelmanager = GameObject.FindObjectOfType<LevelManager>();
		//Restart = Restart.GetComponent<Button>();
		MainMenu = MainMenu.GetComponent<Button>();
	}



	public void gotoMain (){
		levelmanager.LoadLevel("StartScene");
	}
	
	 //Update is called once per frame
	 //void Update () {
		
	//}
}
