using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsAgent : MonoBehaviour
{
    public Rigidbody rb { get; protected set; }
    public Transform tf { get; protected set; }
    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
    }
}
