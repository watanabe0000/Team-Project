using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour {
    [SerializeField]
    private GameObject _gameController;

    private GameController _controller;

    private Vector2 _arrivalPos;

    [SerializeField]
    private float _speed;


    void Start()
    {
        _controller = _gameController.GetComponent<GameController>();

        _arrivalPos = _controller.GetTouchStartPos();
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _arrivalPos, _speed * Time.deltaTime);

        if (_arrivalPos.y <= transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
