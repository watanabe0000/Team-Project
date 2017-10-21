using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private float _delayTime;

    private GameObject _Arrow;
    private GameObject _Thrower;

    [SerializeField]
    private GameObject _AttackType;
    private AttackType _Type;

    public Vector3 _aaa;

    [SerializeField]
    private float wall_line;

    // UI
    [SerializeField]
    private Slider _arrowSlider;
    [SerializeField]
    private Slider _throwerSlider;

    public Vector3 MousePos()
    {
        //スクリーン座標→ワールド座標
        var WorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        return WorldPos;
    }

    void Start()
    {
        _Arrow = Resources.Load<GameObject>("Arrow");
        _Thrower = Resources.Load<GameObject>("Thrower");

        _Type = _AttackType.GetComponent<AttackType>();
    }


    //if (Input.GetButtonDown("Fire1") && MousePos().y > _line.transform.position.y)

    void Update()
    {
        _arrowSlider.value += Time.deltaTime;
        _throwerSlider.value += Time.deltaTime;

        if (Input.GetButtonDown("Fire1"))
        {
            _aaa = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (_aaa.y > wall_line)
            {
                // 矢出現
                if (_Type._type == 0 && _arrowSlider.maxValue <= _arrowSlider.value)
                {
                    Type(_Arrow, _arrowSlider);
                }
                // 投石器出現
                else if (_Type._type == 1 && _throwerSlider.maxValue <= _throwerSlider.value)
                {
                    StartCoroutine(DelayMethod(1.0f));
                    //_aaa = MousePos();
                    //Type(_Thrower, _throwerSlider);
                }
            }
        }

    }

    private IEnumerator DelayMethod(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Type(_Thrower, _throwerSlider);
    }

    void Type(GameObject obj, Slider slider)
    {
        slider.value = 0;

        Instantiate(obj, new Vector2(_aaa.x, wall_line + obj.transform.localScale.y / 4), Quaternion.identity);
    }
}
