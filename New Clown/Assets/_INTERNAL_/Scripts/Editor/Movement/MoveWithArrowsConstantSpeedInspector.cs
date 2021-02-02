using UnityEngine;
using System.Collections;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(MoveWithArrowsConstantSpeed))]
public class MoveWithArrowsConstantSpeedInspector : InspectorBase
{
    private string explanation = "The GameObject moves when pressing specific keys. Choose between Arrows or WASD.";
    private string constraintsReminder = "If you want, you can constrain movement on the X/Y axes in the Rigidbody2D's properties.";
    private string gravityReminder = "Set the gravity to ZERO and make when choosing ALL DIRECTIONS movement type";


    public override void OnInspectorGUI()
    {
        GUILayout.Space(10);
        EditorGUILayout.HelpBox(explanation, MessageType.Info);

        //base.OnInspectorGUI();
        EditorGUILayout.PropertyField(serializedObject.FindProperty("typeOfControl"));

        EditorGUILayout.PropertyField(serializedObject.FindProperty("speed"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("movementType"));

        if (serializedObject.FindProperty("movementType").intValue != 0)
        {
            EditorGUILayout.HelpBox(constraintsReminder, MessageType.Info);
        }
        else
        {
            EditorGUILayout.HelpBox(gravityReminder, MessageType.Info);
        }

        GUILayout.Space(5);
        GUILayout.Label("Orientation", EditorStyles.boldLabel);
        bool orientToDirectionTemp = EditorGUILayout.Toggle("Orient to direction", serializedObject.FindProperty("orientToDirection").boolValue);
        if (orientToDirectionTemp)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("lookAxis"));
        }
        serializedObject.FindProperty("orientToDirection").boolValue = orientToDirectionTemp;

        serializedObject.ApplyModifiedProperties();
    }
}