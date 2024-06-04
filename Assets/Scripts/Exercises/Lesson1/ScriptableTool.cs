using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScriptableTool
{
    [MenuItem("ScriptableObject/CreateDataExercise")]
    public static void CreateData() {
        SettingInfo settingInfo = ScriptableObject.CreateInstance<SettingInfo>();
        AssetDatabase.CreateAsset(settingInfo,"Assets/Resources/SettingInfo.asset");
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}
