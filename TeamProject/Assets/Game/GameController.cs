using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private SelectedWeapon _selectedWeapon;

    private float _wallLine;

    void Start()
    {
        _wallLine = -100;

        _selectedWeapon = GameObject.Find("SelectedWeapon").GetComponent<SelectedWeapon>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var tappedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (tappedPos.y > _wallLine)
            {
                // 弾の生成
                _selectedWeapon.GenerateBullet(tappedPos);
            }
        }

    }

    public float GetWallLine() { return _wallLine; }
}
