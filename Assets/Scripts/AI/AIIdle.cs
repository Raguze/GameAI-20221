using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIIdle : IAIAction
{
    public int Points { get; set; }

    public int Calculate()
    {
        Points = Random.Range(0, 40);
        return Points;
    }

    public bool Condition()
    {
        return true;
    }

    public IEnumerator Exec(PhysicsAgent agent)
    {
        Debug.Log("Start Idle Exec");
        yield return new WaitForSeconds(5f);
        Debug.Log("End Idle Exec");
    }
}
