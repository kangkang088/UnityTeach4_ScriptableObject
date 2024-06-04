using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScriptableObjectTool
{
    [MenuItem("ScriptableObject/CreateMyData")]
    public static void CreateMyData() {
        MyData asset = ScriptableObject.CreateInstance<MyData>();
        AssetDatabase.CreateAsset(asset,"Assets/Resources/MyDataTest.asset");
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}
