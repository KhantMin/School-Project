using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public float sinkSpeed = 2.5f;
    public int scoreValue = 10;

   
    ParticleSystem hitParticles;
    CapsuleCollider capsuleCollider;
    bool isDead;
   


    void Awake ()
    {
        hitParticles = GetComponentInChildren <ParticleSystem> ();
        capsuleCollider = GetComponent <CapsuleCollider> ();

        currentHealth = startingHealth;
    }

    public void TakeDamage (int amount, Vector3 hitPoint)//player hit damage, hit point
    {
        if(isDead)
            return;


        currentHealth -= amount;
            
        hitParticles.transform.position = hitPoint;
        hitParticles.Play();

        if(currentHealth <= 0)
        {
			ScoreManager.score += scoreValue;
            Death ();
            Destroy(gameObject,1f);
        }
    }


    void Death ()
    {
        isDead = true;

        capsuleCollider.isTrigger = true;

    }

}
