using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackType : MonoBehaviour {
    private enum _Type{
        _arrow,
        _thrower,
        _oil,
    }

    private int _type;

    private GameObject _Oil;

    [SerializeField]
    private GameObject _line;

	// Use this for initialization
	void Start () {
        _type = 0;

        _Oil = Resources.Load<GameObject>("Oil");
	}

    public void Arrow()
    {
        _type = (int)_Type._arrow;
    } 

    public void Thrower()
    {
        _type = (int)_Type._thrower;
    }

    public void Oil()
    {
        Instantiate(_Oil, new Vector2(0, _line.transform.position.y + 0.25f), Quaternion.identity);
    }
}
