using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMoveForce : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveForce = 5f;
    public float jumpForce = 5f;
    public float maxSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector2(move * moveForce, 0));

        if (Mathf.Abs(rb.velocity.x) > maxSpeed)
        {
            rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y);
        }
        
        
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
