
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float health = 10f;

    public void takeDamage (float amount)
    {
        health -= amount;
        if ( health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
