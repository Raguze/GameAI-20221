using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsAgent : MonoBehaviour
{
    public Rigidbody rb { get; protected set; }
    public Transform tf { get; protected set; }

    public NavMeshAgent agent { get; protected set; }
    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
    }
}
