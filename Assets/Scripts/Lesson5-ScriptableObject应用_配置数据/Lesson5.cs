using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    public RoleInfo roleInfo;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i < roleInfo.roleDataList.Count;i++) {
            roleInfo.roleDataList[i].Print();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
