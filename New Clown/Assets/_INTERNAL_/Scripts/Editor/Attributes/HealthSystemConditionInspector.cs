using UnityEngine;
using System.Collections;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(HealthSystemAttrCondition))]
public class ModifyHealthAttributeInspector_ : ConditionInspectorBase
{
    private string explanation = "This scripts allows the Players or other objects to receive damage. " +
    	                         "When health reaches ZERO, you can call an action!";

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        GUILayout.Space(10);
        EditorGUILayout.HelpBox(explanation, MessageType.Info);

        GUILayout.Space(10);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("health"));

        GUILayout.Space(10);
        DrawActionLists();

        if (GUI.changed)
        {
            serializedObject.ApplyModifiedProperties();
        }

    }
}
