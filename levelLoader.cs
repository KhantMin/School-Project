using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelLoader : MonoBehaviour {

	GameObject player;
	public int WinScore = 100;
	private LevelManager levelManager;
	PlayerHealth playerHealth;



	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth>();
	}


	void Update ()
	{
		if (ScoreManager.score >= WinScore) {
			levelManager.LoadNextLevel ();

		}

		//if (playerHealth.) {
		//	levelManager.LoadLevel ("FirstLevel");
		//}

    }


}
