using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    static private InputController _instance;

    private float horizontal;
    private float vertical;
    private Vector2 mousePosition;
    private Vector3 screenToWorld;
    //static public 

    static public InputController Instance 
    { 
        get {
            if(_instance == null)
            {
                CreateInstance();
            }
            Debug.Log("Get InputController");
            return _instance;
        }
    }

    static private void CreateInstance()
    {
        GameObject go = new GameObject("InputController");
        InputController ic = go.AddComponent<InputController>();
        _instance = ic;

        Debug.Log("Create InputController");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        mousePosition = Input.mousePosition;
        screenToWorld = Camera.main.ScreenToWorldPoint(mousePosition);

        

        EmitEvents();
    }

    private void EmitEvents()
    {
        GameEvents.InputHorizontal.Invoke(horizontal);
        GameEvents.InputVertical.Invoke(vertical);
        GameEvents.InputMousePosition.Invoke(mousePosition);
        GameEvents.ScreenToWorld.Invoke(screenToWorld);
    }
}
