using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuScript : MonoBehaviour {
   
	public Button StartText;
	public Button SecondScene;
	public Button ThirdScene;
	public Button FourthScene;
	public Button FifthScene;
	private LevelManager levelmanager;

	// Use this for initialization
	void Start () {
		StartText = StartText.GetComponent<Button>();
		//SecondScene = SecondScene.GetComponent<Button>();
		//ThirdScene = ThirdScene.GetComponent<Button>();
		//FourthScene = FourthScene.GetComponent<Button>();
		//FifthScene = FifthScene.GetComponent<Button>();
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	public void StartLevel ()
	{
		levelmanager.LoadLevel("FirstLevel");
		//levelmanager.LoadNextLevel();
	}

	public void SecondLevel(){
		levelmanager.LoadLevel("Scene2");
	}

	public void ThirdLevel(){
		levelmanager.LoadLevel("Traps");
	}

	public void FourthLevel(){
		levelmanager.LoadLevel("MyGame");
	}

	public void FifthLevel(){
		levelmanager.LoadLevel("LastScene");
	}
}
