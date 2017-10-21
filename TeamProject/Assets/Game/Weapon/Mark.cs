using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mark : MonoBehaviour {
    [SerializeField]
    private float _delayTime;
    
    private GameObject _Thrower;

    [SerializeField]
    private GameObject _line;

    // Use this for initialization
    void Start () {
        _Thrower = Resources.Load<GameObject>("Thrower");

        Invoke("ThrowerSpawn", _delayTime);
	}

    private void ThrowerSpawn()
    {
        Instantiate(_Thrower, new Vector2(transform.position.x, _line.transform.position.y + _Thrower.transform.localScale.y / 4), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
