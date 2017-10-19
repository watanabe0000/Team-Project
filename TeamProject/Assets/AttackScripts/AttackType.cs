using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackType : MonoBehaviour {
    private enum Type{
        _arrow,
        _thrower,
        _oil,
    }

    public int _type;

    private GameObject _Oil;

    [SerializeField]
    private GameObject _line;

    [SerializeField]
    private Slider _OilSlider;

	// Use this for initialization
	void Start () {
        _type = 0;

        _Oil = Resources.Load<GameObject>("Oil");
	}

    private void Update()
    {
        _OilSlider.value += Time.deltaTime;
    }

    public void Arrow()
    {
        _type = (int)Type._arrow;
    } 

    public void Thrower()
    {
        _type = (int)Type._thrower;
    }

    public void Oil()
    {
        if (_OilSlider.value >= _OilSlider.maxValue)
        {
            _OilSlider.value = 0;
            Instantiate(_Oil, new Vector2(_Oil.transform.position.x, _line.transform.position.y), Quaternion.identity);
        }
    }
}
