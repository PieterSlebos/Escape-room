
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float health = 10f;

    public void takeDamage (float damage)
    {
        health -= damage;
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
