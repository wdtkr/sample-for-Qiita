using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class EditorScript : UnityEditor.Editor
    {
        [CustomEditor(typeof(SampleScript))]
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("上記の内容で更新します"))
            {
                var test = target as SampleScript;
                test.InputJson();
            }
        }
    }
}

