using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : PhysicsAgent
{
    public float Horizontal { get; protected set; }
    public float Vertical { get; protected set; }

    private float Speed = 8f;

    protected override void Awake()
    {
        base.Awake();

        AddEvents();
    }

    private void AddEvents()
    {
        GameEvents.InputHorizontal.AddListener(
            (h) =>
            { 
                Horizontal = h; 
            }
        );
        GameEvents.InputVertical.AddListener((v) => { Vertical = v; });
    }

    // Update is called once per frame
    void Update()
    {
        float velocityY = rb.velocity.y;
        rb.velocity = new Vector3(Horizontal, 0, Vertical) * Speed + Vector3.up * velocityY;
    }
}
