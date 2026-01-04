using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth=100;
    public int currentHealth;
    public int lives=3;
    private Vector3 spawnPoint;
    void Start()
    {
        currentHealth=maxHealth;
        spawnPoint=transform.position; 
    }
        public void TakeDamage(int damage)
    {
        currentHealth-=damage;
        Debug.Log("Player Health:"+currentHealth);

        if (currentHealth<=0)
        {
            LoseLife();
        }
    }
    void LoseLife()
    {
        lives--;
        Debug.Log("Lives left:"+lives);

        if (lives>0)
        {
            Respawn();
        }
        else
        {
            Debug.Log("GAME OVER");
        }
    }

    void Respawn()
    {
        currentHealth=maxHealth;
        transform.position=spawnPoint;
    }
}
