using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWalk : IAIAction
{
    public int Points { get; set; }
    public int Calculate()
    {
        Points = Random.Range(0, 50);
        return Points;
    }

    public bool Condition()
    {
        return true;
    }

    public IEnumerator Exec(PhysicsAgent agent)
    {
        return null;
    }

}
