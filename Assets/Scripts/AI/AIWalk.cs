using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIWalk : IAIAction
{
    public int Points { get; set; }
    public int Calculate()
    {
        Points = Random.Range(0, 80);
        return Points;
    }

    public bool Condition()
    {
        return true;
    }

    public IEnumerator Exec(PhysicsAgent agent)
    {
        Vector3 point = GameEnvironment.Instance.GetPatrolPoint();
        agent.NMAgent.SetDestination(point);

        Debug.Log($"Walk Exec Status: {agent.NMAgent.pathStatus}");

        if (agent.NMAgent.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            while(WalkingToDestination(agent.NMAgent))
            {
                yield return null;
            }
        }
        Debug.Log($"Walk Exec END Status: {agent.NMAgent.pathStatus}");
    }

    private bool WalkingToDestination (NavMeshAgent agent)
    {
        float distance = Vector3.Distance(agent.destination, agent.transform.position);
        return distance >= 1.1f;
    }
}
