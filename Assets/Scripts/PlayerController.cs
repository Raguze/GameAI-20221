using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : PhysicsAgent
{
    public float Horizontal { get; protected set; }
    public float Vertical { get; protected set; }

    private float Speed = 8f;

    public Vector2 mousePosition;
    public Vector3 worldPoint;

    public LayerMask hitMask;

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

        GameEvents.InputMousePosition.AddListener((p) => { mousePosition = p; });
        //GameEvents.ScreenToWorld.AddListener((p) => { 
        //    worldPoint = p; 
        //});
    }

    // Update is called once per frame
    void Update()
    {
        float velocityY = rb.velocity.y;
        rb.velocity = new Vector3(Horizontal, 0, Vertical) * Speed + Vector3.up * velocityY;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, hitMask))
        {
            worldPoint = hit.point;
        }

        if(Input.GetMouseButtonDown(0))
        {
            agent.SetDestination(worldPoint);
        }

        //int b;
        //Ex1(out b);
        //worldPoint = Vector3.one;
        //Debug.Log(worldPoint);
        //Ex4(worldPoint);
        //Debug.Log(worldPoint);
        //Ex3(ref worldPoint);
        //Debug.Log(worldPoint);
    }

    void Ex1(out int a)
    {
        a = 1;
    }

    void Ex2(in int a)
    {
        int c = a + 2;
    }

    void Ex3(ref Vector3 pos)
    {
        pos = pos * 2;
    }

    void Ex4(Vector3 pos)
    {
        pos = pos * 2;
    }

}
