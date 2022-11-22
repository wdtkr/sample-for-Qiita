using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EditorScript : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("上記の内容で更新します"))
        {
            var main = target as Main;
            main.InputJson();
        }
    }
}
