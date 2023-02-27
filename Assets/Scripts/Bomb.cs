using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Update score
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            //End game
        }

        Destroy(gameObject);
    }
}
