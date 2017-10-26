using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickScript : MonoBehaviour {
    private Vector2 _touchStartPos;
    private Vector2 _touchEndPos;

    [SerializeField]
    private float _minFlickDistance;

    [SerializeField]
    private GameObject _camera;
    [SerializeField]
    private float _cameraRotateSpeed;

    // Use this for initialization
    void Start () {
        _camera.transform.position = new Vector3(0, 0, -1000);
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

            var direction = GetDirection(_touchStartPos, _touchEndPos);

            if (direction == 0)
            {
                _camera.transform.Translate(-300, 0, 0, Space.World);
            }
            else if (direction == 1)
            {
                _camera.transform.Translate(300, 0, 0, Space.World);
            }

            if (_camera.transform.position.x < 0) _camera.transform.Translate(1200, 0, 0, Space.World);
            if (_camera.transform.position.x > 900) _camera.transform.Translate(-1200, 0, 0, Space.World);
        }
    }

    public short GetDirection(Vector2 __startPos, Vector2 __endPos)
    {
        var diff_X = __endPos.x - __startPos.x;
        var diff_Y = __endPos.y - __startPos.y;

        if (Mathf.Abs(diff_Y) < Mathf.Abs(diff_X)){
            if (diff_X > _minFlickDistance)
            {
                Debug.Log("Left");
                return 0;
            }
            else if (diff_X < -_minFlickDistance)
            {
                Debug.Log("Right");
                return 1;
            }
        }

        return -1;
    }
}
