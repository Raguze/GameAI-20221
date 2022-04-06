using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AIAgent : MonoBehaviour
{
    public PhysicsAgent Agent { get; protected set; }

    protected List<IAIAction> actions = new List<IAIAction>();

    List<IAIAction> updateList = new List<IAIAction>();
    private void Awake()
    {
        Agent = GetComponent<PhysicsAgent>();

        actions.Add(new AIIdle());
        actions.Add(new AIWalk());
    }

    // Update is called once per frame
    void Update()
    {
        //actions.Select((ac) => {
        //    return ac.Condition();
        //}).ToList()

        updateList.Clear();

        actions.ForEach(action => {
            if(action.Condition())
            {
                action.Calculate();
                updateList.Add(action);
            }
        });

        updateList = updateList.OrderBy(action => action.Points).ToList<IAIAction>();
        Debug.Log("AI Agent");
    }
}
