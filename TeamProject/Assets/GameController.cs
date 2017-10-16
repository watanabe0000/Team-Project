using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private GameObject _Arrow;
    private GameObject _Mark;
    
    public GameObject _line;

    private Vector2 _touchStartPos;

    public Vector2 GetTouchStartPos()
    {
        //スクリーン座標→ワールド座標
        var WorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        return WorldPos;
    }

    void Start()
    {
        _Arrow = Resources.Load<GameObject>("Arrow");
        _Mark = Resources.Load<GameObject>("Mark");
    }

    void Update()
    {
        // 矢出現
        if (Input.GetButtonDown("Fire1"))
        {
            _touchStartPos = GetTouchStartPos();

            if (_touchStartPos.y > _line.transform.position.y)
                //Instantiate(_Arrow, new Vector2(_touchStartPos.x, _line.transform.position.y + _Arrow.transform.localScale.y/4), Quaternion.identity);

                Instantiate(_Mark, _touchStartPos, Quaternion.identity);
        }
    }
}
