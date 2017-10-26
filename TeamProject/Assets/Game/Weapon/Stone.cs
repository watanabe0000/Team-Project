using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    [SerializeField]
    private float _speed;
    private Vector2 _arrivalPos;

    void Start()
    {

    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _arrivalPos, _speed * Time.deltaTime);

        if (_arrivalPos.y <= transform.position.y)
        {
            Destroy(gameObject);
        }
    }

    public void SetArrivalPos(Vector2 __arrivalPos) { _arrivalPos = __arrivalPos; }
}
