using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedWeapon : MonoBehaviour {

    [SerializeField]
    private GameObject _arrow, _stone, _oil;
    private GameObject _object;

    [SerializeField]
    private Slider _arrowSlider, _stoneSlider, _oilSlider;
    private Slider _slider;

    private Vector2 _arrivalPos;
    private float _wallLine;

    private short _weaponType;
    
    private enum Type{
        ARROW,
        STONE,
        OIL,
    }

    // Use this for initialization
    void Start ()
    {
        _weaponType = (short)Type.ARROW;
        _object = _arrow;
        _slider = _arrowSlider;

        _wallLine = GameObject.Find("GameController").GetComponent<GameController>().GetWallLine();

    }

    private void Update()
    {
        _arrowSlider.value += Time.deltaTime;
        _stoneSlider.value += Time.deltaTime;
        _oilSlider.value += Time.deltaTime;
    }


    public void GenerateBullet(Vector2 __ArrivalPos)
    {
        var obj = Instantiate(_object, new Vector2(__ArrivalPos.x, _wallLine - 100), Quaternion.identity);

        switch(_weaponType)
        {
            case (short)Type.ARROW:
                obj.GetComponent<Arrow>().SetArrivalPos(__ArrivalPos);
                break;
            case (short)Type.STONE:
                obj.GetComponent<Stone>().SetArrivalPos(__ArrivalPos);
                break;
        }
        
        _slider.value = 0;
    }

    public Vector2 GetArrivalPos()
    {
        return _arrivalPos;
    }

    public void TapArrow()
    {
        _weaponType = (short)Type.ARROW;
        _object = _arrow;
        _slider = _arrowSlider;
        Debug.Log("arrow");
    } 

    public void TapStone()
    {
        _weaponType = (short)Type.STONE;
        _object = _stone;
        _slider = _stoneSlider;
        Debug.Log("stone");
    }

    public void TapOil()
    {
        if (_oilSlider.value >= _oilSlider.maxValue)
        {
            _oilSlider.value = 0;
            Instantiate(_oil, new Vector2(_oil.transform.position.x, _wallLine), Quaternion.identity);
        }
    }
}
