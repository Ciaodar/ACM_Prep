using System;
using UnityEngine;


public class Cameraman : MonoBehaviour
{
    //public PolygonCollider2D confinerCollider;
    public Transform playerTransform;
    public float cameraSmoothSpeed = 0.5f;
    public float offset = 3f;

    void LateUpdate()
    {
        
        // Get the camera's current position
        Vector3 desiredPosition = playerTransform.position;
        Vector3 position = transform.position;
        desiredPosition.z = position.z;
        desiredPosition.y += offset;

        // Keep the camera within the bounds of the polygon collider
//        desiredPosition = confinerCollider.ClosestPoint(desiredPosition);

        // Smoothly move the camera towards the desired position
        position = Vector3.Lerp(position, desiredPosition, cameraSmoothSpeed * Time.deltaTime);
        transform.position = position;
    }
}
