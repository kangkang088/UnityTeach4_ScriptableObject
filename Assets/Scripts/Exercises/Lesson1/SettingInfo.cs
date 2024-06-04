using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "SettingInfo",menuName = "ScriptableObject/音乐音效设置信息")]
public class SettingInfo : ScriptableObject
{
    public bool musicIsOpen;
    public bool soundIsOpen;
    public float musicIntensity;
    public float soundIntensity;
    private void Awake() {
        if(File.Exists(Application.persistentDataPath + "/SettingInfo.json")) {
            string jsonStr = File.ReadAllText(Application.persistentDataPath + "/SettingInfo.json");
            JsonUtility.FromJsonOverwrite(jsonStr,this);
        }
    }
    public void Save() {
        string jsonStr = JsonUtility.ToJson(this);
        File.WriteAllText(Application.persistentDataPath + "/SettingInfo.json",jsonStr);
    }
}
