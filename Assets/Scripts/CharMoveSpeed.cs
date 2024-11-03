using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMoveSpeed : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);
    }


}
