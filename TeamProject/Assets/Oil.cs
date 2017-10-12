using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour {
    private float _scaleY;

	// Use this for initialization
	void Start () {
        _scaleY = 0;
	}
	
	// Update is called once per frame
	void Update () {
        _scaleY += Time.deltaTime;

        //transform.position = Vector2.MoveTowards(transform.position, transform.position, _scaleY);
        transform.localScale = new Vector2(20, _scaleY);

        if (_scaleY >= 1.0f)
        {
            Destroy(gameObject);
        }
	}
}
