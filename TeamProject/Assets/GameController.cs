using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private GameObject _Arrow;

    [SerializeField]
    private GameObject _line;

    private Vector2 _touchStartPos;

    public Vector2 GetTouchStartPos()
    {
        //スクリーン座標→ワールド座標
        var WorldPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x,
                                                                    Input.mousePosition.y));

        return WorldPos;
    }

    private Vector2 _startPos;

    public Vector2 GetStartPos()
    {
        return _startPos;
    }

    void Start()
    {
        _Arrow = Resources.Load<GameObject>("Arrow");
    }

    void Update()
    {
        // 矢出現
        if (Input.GetButtonDown("Fire1"))
        {
            _touchStartPos = GetTouchStartPos();

            Instantiate(_Arrow, new Vector2(_touchStartPos.x, _line.transform.position.y), Quaternion.identity);
        }
    }
}
