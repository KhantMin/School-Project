using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoaderSpace : MonoBehaviour {

	private LevelManager levelManager;
	GameObject player;
	bool kerry;

	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		player = GameObject.FindGameObjectWithTag ("Player");
		kerry = false;
	}


	void OnTriggerEnter (Collider other)//other is whatever the object is collided
    {
        if(other.gameObject == player)
        {
            kerry = true;
        }
    }


    void OnTriggerExit (Collider other)
    {
        if(other.gameObject == player)
        {
            kerry = false;
        }
    }


	void Update(){

	if(kerry)
		asd();

	}


	void asd(){
		levelManager.LoadNextLevel();
	}
}
