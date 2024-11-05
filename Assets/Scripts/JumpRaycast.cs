using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRaycast : MonoBehaviour
{
    public float jumpForce = 5f;
    public bool grounded = false;
    public int airjumpnumber = 1;
    public int airjumps = 0;
    public LayerMask groundLayer;
    Rigidbody2D rb;
    Animator anim;
    
    public float raydist = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        RaycastHit2D hit =Physics2D.Raycast(transform.position, Vector2.down, raydist, groundLayer);
        if (hit.collider != null)
        {
            grounded = true;
            airjumps = 0;
        }
        else
        {
            grounded = false;
        }
        anim.SetBool("ground", grounded);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * raydist);
    }

    private void Update()
    {
        anim.SetFloat("speedy", rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            if (grounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
            else if (airjumps < airjumpnumber)
            {
                airjumps++;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
            
            
            anim.SetTrigger("jump");
        }
        
    }
}
