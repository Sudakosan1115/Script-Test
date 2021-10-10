using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //　要素数5のint型の配列arrayを追加
        int[] array = new int[5];
        // 配列の各要素に値を代入する
        array[0] = 1;
        array[1] = 10;
        array[2] = 100;
        array[3] = 1000;
        array[4] = 10000;
        // 5回処理を繰り返す
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        // 5回逆に繰り返す
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}