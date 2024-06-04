using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleScriptableObject<T> : ScriptableObject where T : ScriptableObject {
    private static T instance;
    public static T Instance {
        get {
            if(instance == null) {
                //如果为空，首先去资源路径下加载对应的资源数据文件
                //两个规则：所有的资源文件都放在resources资源文件夹下面的ScriptableObject文件下
                //需要复用的唯一数据资源文件名和类名一样
                instance = Resources.Load<T>("ScriptableObject/" + typeof(T).Name);
            }
            //如果没有这个文件，直接创建一个数据文件
            if(instance == null) {
                instance = ScriptableObject.CreateInstance<T>();
            }
            return instance;
        }
    }
}
