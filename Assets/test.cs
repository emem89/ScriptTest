using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        if (mp < 5)
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
        else
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }

    }
}

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �ȉ��ALesson4�ۑ�
        int[] array = {5, 8, 3, 1, 9, 7};

        // array�����Ԃɕ\������
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array [i]);
        }

        // array���t���ɕ\������
        Array.Reverse(array);   // ���Ԃ𔽓]������
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // �ȉ��A���W�ۑ�
        Debug.Log("�ȉ��A���W�ۑ�");

        Boss lastboss = new Boss ();

        for(int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
