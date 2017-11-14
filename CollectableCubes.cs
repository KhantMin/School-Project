using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCubes : MonoBehaviour {

	public int ScoreValue = 10;
	private LevelManager levelManager;
	GameObject player;
	bool kerry;

	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		player = GameObject.FindGameObjectWithTag ("Player");
		kerry = false;
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * 2);
	}


	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == player) {
			ScoreManager.score += ScoreValue;
			gameObject.SetActive(false);
			ASD();
		}
    }


    void ASD(){

    	if(ScoreManager.score >= 90){
    	levelManager.LoadNextLevel();
    }
    }
}

