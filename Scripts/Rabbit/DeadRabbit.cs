using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadRabbit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet" || collision.tag == "Wolf" || collision.tag == "Death")
            Destroy(gameObject);
    }
}
