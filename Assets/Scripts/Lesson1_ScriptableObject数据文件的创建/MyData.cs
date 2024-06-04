using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MyScriptableObject",menuName = "Scriptabel/�ҵ�����������Դ�ļ�",order = 0)]
public class MyData : ScriptableObject {
    public int id;
    public string name;
    public bool b;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject obj;
    public Material m;
    public void PrintInfo() {
        Debug.Log(id + "; " + name + ": " + b);
    }

}
