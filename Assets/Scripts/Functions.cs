using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    //Once When Created
    private void Awake()
    {
        throw new NotImplementedException();
    }

    //Once when enabled
    private void Start()
    {
        throw new NotImplementedException();
    }
    
    // Cyclic functions
    private void FixedUpdate() 
    {
        throw new NotImplementedException();
    }
    
    private void Update() // "every" frame
    {
        throw new NotImplementedException();
    }
    
    private void LateUpdate() // camera follow
    {
        throw new NotImplementedException();
    }
    //Cyclic
    
    
    
    //Trigger Functions
    private void OnEnable() // "every" time the object is enabled (not once like the Start())
    {
        throw new NotImplementedException();
    }
    
    private void OnDisable() // "every" time the object is disabled 
    {
        throw new NotImplementedException();
    }
    
    
    
    
    //Collision Functions
    private void OnCollisionEnter2D(Collision2D other)
    {
        throw new NotImplementedException();
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        throw new NotImplementedException();
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        throw new NotImplementedException();
    }
    
    //Trigger Functions
    private void OnTriggerEnter2D(Collider2D other)
    {
        throw new NotImplementedException();
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        throw new NotImplementedException();
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        throw new NotImplementedException();
    }
}
