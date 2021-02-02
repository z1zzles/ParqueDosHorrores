using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(ConditionWaitTime))]
public class ConditionWaitTimeInspector : ConditionInspectorBase
{
    private string explanation = "Use this script to perform an action after some time. Reload the Timer by Enable/Disable this GameObject";

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        GUILayout.Space(10);
        EditorGUILayout.HelpBox(explanation, MessageType.Info);

        GUILayout.Space(10);

        EditorGUILayout.PropertyField(serializedObject.FindProperty("delay"));

        GUILayout.Space(10);
        DrawActionLists();

        serializedObject.ApplyModifiedProperties();
    }
}
