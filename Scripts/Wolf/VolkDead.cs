using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfDead : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet"|| collision.tag=="Death")
        Destroy(gameObject);
    }
}
