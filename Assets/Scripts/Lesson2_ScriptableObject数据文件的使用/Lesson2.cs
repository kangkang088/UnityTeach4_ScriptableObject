using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    public MyData data;
    // Start is called before the first frame update
    void Start()
    {
        data = Resources.Load<MyData>("MyDataTest");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
