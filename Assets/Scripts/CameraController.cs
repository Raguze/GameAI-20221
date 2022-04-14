using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform tf;

    private void Awake()
    {
        tf = GetComponent<Transform>();
    }

    public Vector3 currentVelocity = new Vector3();
    public float smoothTime = 0.05f;
    public float maxSpeed = 8f;

    public Transform Target { get; set; }
    private void LateUpdate()
    {
        if (Target)
        {
            tf.position = Vector3.SmoothDamp(tf.position, Target.position, ref currentVelocity, smoothTime, maxSpeed);
        }
    }
}
