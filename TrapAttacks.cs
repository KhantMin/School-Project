using UnityEngine;
using System.Collections;

public class TrapAttacks : MonoBehaviour
{
    public float timeBetweenAttacks = 3f;
    public int attackDamage = 10;


    Animator anim;
    GameObject player;
    PlayerHealth playerHealth;
    bool playerInRange;
    float timer;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
        playerHealth = player.GetComponent <PlayerHealth> ();
       	//anim = GetComponent <Animator> ();
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
        if(other.gameObject == player)
        {
            playerInRange = false;
        }
    }


    void Update ()
    {
        timer += Time.deltaTime;

        if(timer >= timeBetweenAttacks && playerInRange )
        {
            Attack ();
        }

    }


    void Attack ()
    {
        timer = 0f;

        if(playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage (attackDamage);
        }
    }
}
