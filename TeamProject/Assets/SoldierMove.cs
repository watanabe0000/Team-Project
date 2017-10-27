using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMove : MonoBehaviour
{

    // 移動
    Vector2 _velocity;
    [SerializeField]
    private float _speedY;
    [SerializeField]
    private float _SpeedX;
    [SerializeField]
    private float _shakeWidth;
    private float _th;

    // ステータス
    [SerializeField]
    private int _hp;
    [SerializeField]
    private float _attackTime;

    //[SerializeField]
    //private GameObject _wall = null;

    private Rigidbody2D m_rigidbody2D;

    // Use this for initialization
    void Start()
    {
        _velocity = Vector2.zero;

        _th = 0;

        m_rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _th += _SpeedX * Time.deltaTime;
        _velocity.x = Mathf.Cos(_th) * _shakeWidth;
        _velocity.y -= _speedY * Time.deltaTime;

        m_rigidbody2D.velocity = _velocity;

        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "aaa")
        {
            _hp -= 1;
        }

        if (gameObject.tag == "bbb")
        {
            _hp -= 10;
        }

        if (gameObject.tag == "ccc")
        {
            _hp -= 5;
        }
    }

    private bool one_hit = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        m_rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;


        if (!one_hit)
        {
            Debug.Log("1");
            StartCoroutine(DelayTime());
        }
    }

    private IEnumerator DelayTime()
    {
        one_hit = true;

        yield return new WaitForSeconds(_attackTime);

        one_hit = false;
    }
}
