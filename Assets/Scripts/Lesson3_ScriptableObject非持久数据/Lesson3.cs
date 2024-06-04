using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    public MyData data;
    // Start is called before the first frame update
    void Start()
    {
        data = ScriptableObject.CreateInstance<MyData>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
