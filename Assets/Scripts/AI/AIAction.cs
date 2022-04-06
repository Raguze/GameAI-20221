using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAction : IAIAction
{
    public int Points { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public int Calculate()
    {
        throw new System.NotImplementedException();
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
