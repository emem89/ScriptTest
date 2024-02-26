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
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        else
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }

    }
}

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 以下、Lesson4課題
        int[] array = {5, 8, 3, 1, 9, 7};

        // arrayを順番に表示する
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array [i]);
        }

        // arrayを逆順に表示する
        Array.Reverse(array);   // 順番を反転させる
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // 以下、発展課題
        Debug.Log("以下、発展課題");

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
