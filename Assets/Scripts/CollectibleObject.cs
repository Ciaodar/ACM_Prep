using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleObject : MonoBehaviour
{
    private Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.coins++;
        Debug.Log(GameManager.coins);
        Destroy(gameObject);
    }
}
