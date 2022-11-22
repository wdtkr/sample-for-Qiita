
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SampleScript))]
public class SampleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("上記の内容で更新します"))
        {
            var sample = target as SampleScript;
            sample.InputJson();
        }
    }
}
