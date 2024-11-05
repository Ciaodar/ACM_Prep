using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMoveSpeed : MonoBehaviour
{
    public float move;
    Rigidbody2D rb;
    public float moveSpeed = 5f;
    
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);
        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        CharacterFlip();
    }

    void CharacterFlip()
    {
        if (move > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (move < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

}
