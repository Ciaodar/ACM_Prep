using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public float jumpForce = 5f;
    public bool grounded = false;
    public int airjumpnumber = 1;
    public int airjumps = 0;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(grounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
            else if(airjumps < airjumpnumber)
            {
                airjumps++;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        grounded = true;
        airjumps = 0;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        grounded = false;
    }
}
