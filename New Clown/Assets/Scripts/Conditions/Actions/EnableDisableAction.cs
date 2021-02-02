using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Actions/Enable-Disable")]
public class EnableDisableAction : Action
{
    public GameObject objectToAffect;
    public bool enable;


    // Changes the object state from active to inactive, and viceversa
    public override bool ExecuteAction(GameObject dataObject)
    {
        if (objectToAffect != null)
        {
            objectToAffect.SetActive(enable);
        }

        return true;
    }
}
