using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    LevelManager levelmanager;
	private IEnumerator coroutine;
	bool dead;

    Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
    }


  
    void Update()
    {

        if (playerHealth.currentHealth <= 0)
        {
     
			dead = true;
			//anim.SetTrigger("GameOver");
			levelmanager.LoadLevel("GameOverScreen");

			//levelmanager.loadCurrentLevel();

		}


	}


    }
   


