using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        Debug.Log(hp);
        // 残りhpを減らす
        this.hp -= damage;
    }
    public void Magic(int magic)
    {
        int sum = 0;
        for (int i = 0; i < mp; i += magic)
        {
            sum = i;
        
        Debug.Log("魔法攻撃をした。残りMPは" + (this.mp - sum));
    }
        if ((this.mp - sum) <5)
        { 
            Debug.Log("MPが足りないため魔法が使えない。");

    }
        }
    }



    public class Test : MonoBehaviour
    {
        int[] array = { 0, 1, 2, 3, 4 };
        void Start()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Debug.Log(array[i]);
            }
            for (int i = 4; i >= 0; i--)
            {
                Debug.Log(array[i]);
            }

            // Bossクラスの変数を宣言してインスタンスを代入
            Boss midboss = new Boss();

            // 攻撃用の関数を呼び出す
            midboss.Attack();
            // 防御用の関数を呼び出す
            midboss.Defence(3);
            midboss.Magic(5);


        }


        // Update is called once per frame
        void Update()
        {

        }
    }

 
