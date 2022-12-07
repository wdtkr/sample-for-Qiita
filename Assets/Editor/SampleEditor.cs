using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SampleScript))]
public class SampleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var sample = target as SampleScript;
        
        if (GUILayout.Button("JSONを読み込む"))
        {
            sample.LoadJson();
        }
        
        if (GUILayout.Button("JSONを更新する"))
        {
            sample.UpdateJson();
        }
    }
}