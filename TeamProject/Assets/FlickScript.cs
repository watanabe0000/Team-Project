using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickScript : MonoBehaviour {
    private Vector2 _touchStartPos;
    private Vector2 _touchEndPos;

    [SerializeField]
    private float _minFlickPower;

    [SerializeField]
    private GameObject _camera;
    [SerializeField]
    private float _cameraRotateSpeed;

    private int Direction;

    // Use this for initialization
    void Start () {
        Direction = 0;
	}
	
	// Update is called once per frame
	void Update () {

        // フリック
        if (Input.GetButtonDown("Fire1"))
        {
            _touchStartPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }

        if (Input.GetButtonUp("Fire1"))
        {
            _touchEndPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            GetDirection();
        }

        if (Direction == 1)
        {
            var value = _cameraRotateSpeed * Time.deltaTime;
            _camera.transform.Rotate(0, 0, value, Space.World);
        }
        else if (Direction == 2)
        {
            var value = _cameraRotateSpeed * Time.deltaTime;
            _camera.transform.Rotate(0, 0, -value, Space.World);
        }
        else
        {
            _camera.transform.localRotation = Quaternion.identity;
        }
    }

    public void GetDirection()
    {
        var _directionX = _touchEndPos.x - _touchStartPos.x;
        var _directionY = _touchEndPos.y - _touchStartPos.y;

        if (Mathf.Abs(_directionY) < Mathf.Abs(_directionX)){
            if (_minFlickPower < _directionX)
            {
                Direction = 1;
                Debug.Log("Left");
            }
            else if (-_minFlickPower > _directionX)
            {
                Direction = 2;
                Debug.Log("Right");
            }
        }
        else
        {
            Debug.Log("Touch");
        }

    }
}
