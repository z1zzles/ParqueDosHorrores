using UnityEngine;
using System.Collections;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(EnableDisableAction))]
public class EnableDisableActionInspector : InspectorBase
{
    private string explanation = "Use this script to enable or disable object.";

    public override void OnInspectorGUI()
    {
        GUILayout.Space(10);
        EditorGUILayout.HelpBox(explanation, MessageType.Info);

        GUILayout.Space(10);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("objectToAffect"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("enable"));

        if (GUI.changed)
        {
            serializedObject.ApplyModifiedProperties();
        }
    }
}
