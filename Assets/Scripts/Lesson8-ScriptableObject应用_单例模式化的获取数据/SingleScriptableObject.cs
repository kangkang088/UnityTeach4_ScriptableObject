using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleScriptableObject<T> : ScriptableObject where T : ScriptableObject {
    private static T instance;
    public static T Instance {
        get {
            if(instance == null) {
                //���Ϊ�գ�����ȥ��Դ·���¼��ض�Ӧ����Դ�����ļ�
                //�����������е���Դ�ļ�������resources��Դ�ļ��������ScriptableObject�ļ���
                //��Ҫ���õ�Ψһ������Դ�ļ���������һ��
                instance = Resources.Load<T>("ScriptableObject/" + typeof(T).Name);
            }
            //���û������ļ���ֱ�Ӵ���һ�������ļ�
            if(instance == null) {
                instance = ScriptableObject.CreateInstance<T>();
            }
            return instance;
        }
    }
}
