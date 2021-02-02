using UnityEngine;
using System.Collections;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(AnimationAction))]
public class AnimationActionInspector : InspectorBase
{
    private string explanation = "Use this script to execute an animation";
    private string objectWarning = "WARNING: Assign a object with an Animator component!";

    public override void OnInspectorGUI()
    {
        GUILayout.Space(10);
        EditorGUILayout.HelpBox(explanation, MessageType.Info);

        GUILayout.Space(10);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("objectToAnimate"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("paramType"));

        if (!CheckIfAssigned("objectToAnimate", false))
        {
            EditorGUILayout.HelpBox(objectWarning, MessageType.Warning);
        }

        switch (serializedObject.FindProperty("paramType").intValue)
        {
            case 0:
                EditorGUILayout.PropertyField(serializedObject.FindProperty("paramName"));
                break;
            case 1:
                EditorGUILayout.PropertyField(serializedObject.FindProperty("paramName"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("boolValue"));
                break;
            case 2:
                EditorGUILayout.PropertyField(serializedObject.FindProperty("paramName"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("intValue"));
                break;
        }

        if (GUI.changed)
        {
            serializedObject.ApplyModifiedProperties();
        }
    }
}
