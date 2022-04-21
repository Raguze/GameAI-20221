using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolGroup : MonoBehaviour
{
    public List<Transform> points = new List<Transform>();

    private int index = 0;

    private void Awake()
    {
        points = transform.GetChildren();
        GameEnvironment.Instance.AddPatrolGroup(this);
    }

    public Vector3 NextPoint()
    {
        int i = index++ % points.Count;
        Debug.Log($"Next {i}");
        return points[i].position;
    }
}
