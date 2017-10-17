using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    
    
    // ベース
    abstract class EnemyBase {
        protected short hp;
        protected float speed;
        protected short atk_pow;
        
    }

    // 兵卒
    class Enemy1 : EnemyBase {
        public Enemy1()
        {
            this.hp = 1;
            this.speed = 3;
            this.atk_pow = 1;
        }


    }

    // 井蘭
    class Enemy2 : EnemyBase
    {
        public Enemy2()
        {
            this.hp = 10;
            this.speed = 1;
            this.atk_pow = 3;
        }
    }

    // 衝車
    class Enemy3 : EnemyBase
    {
        public Enemy3()
        {
            this.hp = 10;
            this.speed = 6;
            this.atk_pow = 3;
        }
    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}
