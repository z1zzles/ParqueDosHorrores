using UnityEngine;
using System.Collections;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(ModifyHealthAttrCondition))]
public class ModifyHealthAttrConditionInspector : InspectorBase
{
    private string explanation = "This GameObject will damage or heal other GameObjects on impact (only if they use the HealthSystemAttribute). " +
    	                         "Negative values mean damage, positive values mean healing (like a medipack).";

    private string warning = "To destroy this object on impact, create an DESTROY ACTION in the other GameObject (that is using HealthSystemAttribute)";

    public override void OnInspectorGUI()
    {
        GUILayout.Space(10);
        EditorGUILayout.HelpBox(explanation, MessageType.Info);
        GUILayout.Space(10);
        EditorGUILayout.HelpBox(warning, MessageType.Warning);

        base.OnInspectorGUI();

        //print a message to explain better that values can be positive or negative
        GUIStyle style = new GUIStyle(EditorStyles.label);

        if (serializedObject.FindProperty("healthChange").intValue < 0)
        {
            style.normal.textColor = Color.red;
            EditorGUILayout.LabelField("This object will damage on impact", style);
        }
        else if (serializedObject.FindProperty("healthChange").intValue > 0)
        {
            style.normal.textColor = Color.blue;
            EditorGUILayout.LabelField("This object will heal on impact", style);
        }
        else
        {
            EditorGUILayout.LabelField("This object will have no effect");
        }
    }
}
