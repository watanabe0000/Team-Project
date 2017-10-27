using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour {

    static Canvas _canvas;
    private void Start()
    {
        _canvas = GetComponent<Canvas>();
    }
    //表示・非表示設定
    //setActive関数
    public static void SetActive(string name, bool b)
    {
        foreach (Transform child in _canvas.transform)
        {

            //子の要
            //名前が一緒ならば
            if (child.name == name)
            {

                child.gameObject.SetActive(b);
                return;

            }

        }
        

}
}
