using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extentions
{
    static public List<Transform> GetChildren(this Transform transform)
    {
        List<Transform> points = new List<Transform>();
        for (int i = 0; i < transform.childCount; i++)
        {
            points.Add(transform.GetChild(i));
        }
        return points;
    }


}
