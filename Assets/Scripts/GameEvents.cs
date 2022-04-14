using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloatEvent : UnityEvent<float> { }

public class Vector2Event : UnityEvent<Vector2> { }

public class Vector3Event : UnityEvent<Vector3> { }

public class GameEvents
{
    static public FloatEvent InputHorizontal = new FloatEvent();
    static public FloatEvent InputVertical = new FloatEvent();
    static public Vector2Event InputMousePosition = new Vector2Event();
    static public Vector3Event ScreenToWorld = new Vector3Event();
}
