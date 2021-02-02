using UnityEngine;
using System.Collections;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(SoundAction))]
public class SoundActionInspector : InspectorBase
{
    private string explanation = "Use this script to execute an Sound";
    private string objectWarning = "WARNING: Assign an object with an AudioSource component!";

    public override void OnInspectorGUI()
    {
        GUILayout.Space(10);
        EditorGUILayout.HelpBox(explanation, MessageType.Info);

        GUILayout.Space(10);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("objectToPlaySound"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("paramType"));

        if (!CheckIfAssigned("objectToPlaySound", false))
        {
            EditorGUILayout.HelpBox(objectWarning, MessageType.Warning);
        }

        switch (serializedObject.FindProperty("paramType").intValue)
        {
            //case 0:
                //EditorGUILayout.PropertyField(serializedObject.FindProperty("paramName"));
                //break;
            case 2:
                EditorGUILayout.PropertyField(serializedObject.FindProperty("audioClip"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("volume"));
                break;
            
        }

        if (GUI.changed)
        {
            serializedObject.ApplyModifiedProperties();
        }

    }


}
