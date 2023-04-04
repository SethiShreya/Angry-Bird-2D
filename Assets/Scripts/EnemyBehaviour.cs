using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float health = 40f;
    public GameManager gameManager;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() != null)
        {
            var damage = collision.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;

            health -= damage;
        if (health < 0)
        {
            gameManager.DecreaseEnemyCount();
            Destroy(transform.gameObject);
        }
        }
    }
}
