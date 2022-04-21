using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnvironment : MonoBehaviour
{
    static private GameEnvironment _instance;

    private Dictionary<int, PatrolGroup> patrolGroups = new Dictionary<int, PatrolGroup>();

    static public GameEnvironment Instance
    {
        get
        {
            if(_instance == null)
            {
                CreateInstance();
            }
            return _instance;
        }
    }

    private static void CreateInstance()
    {
        GameObject go = new GameObject("GameEnvironment");
        GameEnvironment ge = go.AddComponent<GameEnvironment>();
        _instance = ge;
    }

    public void Init() { }

    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    public void AddPatrolGroup(PatrolGroup group)
    {
        patrolGroups.Add(0, group);
    }

    public Vector3 GetPatrolPoint()
    {
        return patrolGroups[0].NextPoint();
    }

    public Vector3 GetRestPoint()
    {
        return Vector3.zero;
    }
}
