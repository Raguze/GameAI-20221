using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AIAgent : MonoBehaviour
{
    public PhysicsAgent Agent { get; protected set; }

    protected List<IAIAction> actions = new List<IAIAction>();

    List<IAIAction> updateList = new List<IAIAction>();

    Coroutine updateAICoroutine;
    private void Awake()
    {
        Agent = GetComponent<PhysicsAgent>();

        actions.Add(new AIIdle());
        actions.Add(new AIWalk());
    }

    void Start()
    {
        Alive();
    }

    public void Alive()
    {
        if(updateAICoroutine == null)
        {
            updateAICoroutine = StartCoroutine(UpdateAI());
        }
    }

    public void Die()
    {
        StopCoroutine(updateAICoroutine);
        updateAICoroutine = null;
    }

    // Update is called once per frame
    IEnumerator UpdateAI()
    {
        //actions.Select((ac) => {
        //    return ac.Condition();
        //}).ToList()

        while(true)
        {
            updateList.Clear();

            actions.ForEach(action => {
                if (action.Condition())
                {
                    action.Calculate();
                    updateList.Add(action);
                }
            });

            updateList = updateList.OrderByDescending(action => action.Points).ToList<IAIAction>();
            IAIAction action = updateList[0];
            //StartCoroutine(action.Exec(Agent));
            //Debug.Log("AI Agent");
            Debug.Log($"{action.GetType()} {action.Points}");
            yield return new WaitForSeconds(5f);
        }
    }
}
