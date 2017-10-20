using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour {
    private Vector3 _arrivalPos;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private GameObject _gameController;

    private GameController _controller;

    void Start()
    {
        _controller = _gameController.GetComponent<GameController>();

        _arrivalPos = _controller._aaa;
        Debug.Log(_controller._aaa);
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _arrivalPos, _speed * Time.deltaTime);

        /*if (_arrivalPos.y <= transform.position.y)
        {
            Destroy(gameObject);
        }*/
    }

   
}
