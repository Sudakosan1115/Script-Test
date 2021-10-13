using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
    private int hp = 100; // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;  // 魔力
                          // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    // 魔法攻撃用の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            // mpが5以上の場合、残りmpを減らして魔法攻撃
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            // mpが5以下の場合
            Debug.Log("mpがたりないため、魔法攻撃が使えない");
        }
    }
}
    public class Test : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        for (int i = 0; i < 11; i++)
        {
            // 攻撃用の関数を呼び出す
            lastboss.Magic();
        }


        }
        // Update is called once per frame
        void Update()
        {
        }
    }