using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIRest : IAIAction
{
    public int Points { get; set; }

    private float lastTime = 0;

    public int Calculate()
    {
        return 100;
    }

    public bool Condition()
    {
        return Time.realtimeSinceStartup - lastTime >= 30f;
    }

    public IEnumerator Exec(PhysicsAgent agent)
    {
        lastTime = Time.realtimeSinceStartup;
        Vector3 point = GameEnvironment.Instance.GetRestPoint();
        agent.NMAgent.SetDestination(point);

        Debug.Log($"Rest Exec Status: {agent.NMAgent.pathStatus}");

        if (agent.NMAgent.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            while (Vector3.Distance(agent.NMAgent.destination,agent.transform.position) <= 1.1f)
            {
                yield return null;
            }

            Debug.Log("Rest Destination");
            yield return new WaitForSeconds(8f);
        }
    }

}
