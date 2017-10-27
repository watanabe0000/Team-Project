using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourBase : MonoBehaviour {

    // ベース
    abstract class EnemyBase {
        protected short hp;
        protected float speed;
        protected short power;

        public abstract void move();
        public abstract void damaged();
    }

    // 兵卒
    class Enemy1 : EnemyBase
    {
        public Enemy1()
        {
            this.hp = 1;
            this.speed = 3;
            this.power = 1;
        }

        public override void move()
        {

        }

        public override void damaged()
        {

        }
    }

    // 井蘭
    class Enemy2 : EnemyBase
    {
        public Enemy2()
        {
            this.hp = 10;
            this.speed = 1;
            this.power = 3;
        }

        public override void move()
        {

        }

        public override void damaged()
        {

        }
    }

    // 衝車
    class Enemy3 : EnemyBase
    {
        public Enemy3()
        {
            this.hp = 10;
            this.speed = 6;
            this.power = 3;
        }

        public override void move()
        {

        }

        public override void damaged()
        {

        }
    }

    private void Start()
    {
        
    }

    private void Update()
    {

    }
}
