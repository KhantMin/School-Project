using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {

	public float delayTime;
	GameObject player;
    PlayerHealth playerHealth;
	bool playerInRange;
	public int attackDamage = 10;

	void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
        playerHealth = player.GetComponent <PlayerHealth> ();
       	//anim = GetComponent <Animator> ();
    }


	void OnCollisionEnter (Collision other)
	{

		if (other.gameObject == player) {
			playerHealth.TakeDamage (attackDamage);

		}
	}

	void OnTriggerEnter (Collider other)//other is whatever the object is collided
    {
        if(other.gameObject == player)
        {
			playerHealth.TakeDamage (attackDamage);
        }
    }


    void OnTriggerExit (Collider other)
	{
		if (other.gameObject == player) {
			playerInRange = false;
		}
	}
}