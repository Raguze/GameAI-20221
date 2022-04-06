using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloatEvent : UnityEvent<float> { }

public class GameEvents
{
    static public FloatEvent InputHorizontal = new FloatEvent();
    static public FloatEvent InputVertical = new FloatEvent();
}
