using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    private float _x;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _x = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_x, 0) * _speed;
    }
}
