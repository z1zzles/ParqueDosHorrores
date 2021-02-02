using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Actions/Animation")]
public class AnimationAction : Action
{
    public Animator objectToAnimate;
    public enum Type { Trigger, Bool, Int }
    public Type paramType;

    public string paramName;
    public bool boolValue;
    public int intValue;


    // Moves the GameObject instantly to a custom position
    public override bool ExecuteAction(GameObject dataObject)
    {
        Animator anim;

        if (objectToAnimate != null)
        {
            anim = objectToAnimate.GetComponent<Animator>();

            switch (paramType)
            {
                case Type.Bool:
                    anim.SetBool(paramName, boolValue);
                    break;
                case Type.Int:
                    anim.SetInteger(paramName, intValue);
                    break;
                case Type.Trigger:
                    anim.SetTrigger(paramName);
                    break;
            }

        }

        return true;
    }
}
