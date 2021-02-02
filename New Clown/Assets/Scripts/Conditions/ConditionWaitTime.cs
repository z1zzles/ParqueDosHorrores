using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Playground/Conditions/Condition Wait Time")]
public class ConditionWaitTime : ConditionBase
{
    public float delay = 0f;
    private float timeLastEventFired;


    private void OnEnable()
    {
        timeLastEventFired = Time.time + delay;
    }


    private void Update()
    {
        if(gameObject.activeInHierarchy)
            if (Time.time >= timeLastEventFired)
            {
                ExecuteAllActions(null);
            }
    }
}