using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Untagged")) return;

        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.IncreaseScore();
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            GameManager.Instance.EndGame();
        }

        Destroy(gameObject);
    }
}
