using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public InputController ic;
    // Start is called before the first frame update
    void Awake()
    {
        InputController ic = InputController.Instance;
        CameraController cameraController = FindObjectOfType<CameraController>();
        PlayerController playerController = FindObjectOfType<PlayerController>();
        cameraController.Target = playerController.tf;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
