using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class is responsible for the character's animation behavior
// This class works by manually changing the states of animator
public class CharAnimBehavior : MonoBehaviour
{
    public float runanimspeed= 1f;
    public float idleanimspeed = 1f;
    public float jumpmidanimspeed = 1f;
    public float fallanimspeed = 1f;
    
    private CharMoveSpeed cms;
    JumpRaycast jr;
    private Animator anim;
    private Rigidbody2D rb;
    private void Start()
    {
        cms = GetComponent<CharMoveSpeed>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        jr = GetComponent<JumpRaycast>();
    }

    private void Update()
    {
        CharacterFlip();
        if((cms.move > 0 || cms.move < 0) && jr.grounded)
        {
            ChangeAnimationState("Run");
            anim.speed = runanimspeed;
        }
        else if (rb.velocity.y > 0 && !jr.grounded)
        {
            ChangeAnimationState("Jump");
            anim.speed = jumpmidanimspeed;
        }
        else if (rb.velocity.y < 0 && !jr.grounded)
        {
            ChangeAnimationState("Fall");
            anim.speed = fallanimspeed;
        }
        else
        {
            ChangeAnimationState("Idle");
            anim.speed = idleanimspeed;
        }
    }
    
    void ChangeAnimationState(string newState)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName(newState)) return;
        anim.Play(newState);
    }

    void CharacterFlip()
    {
        if (cms.move > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (cms.move < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
