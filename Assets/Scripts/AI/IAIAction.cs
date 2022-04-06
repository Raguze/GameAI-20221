using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAIAction
{
    int Points { get; set; }

    bool Condition();
    int Calculate();
    IEnumerator Exec(PhysicsAgent agent);
}
