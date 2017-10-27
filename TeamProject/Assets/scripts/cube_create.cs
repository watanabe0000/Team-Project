using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_create : MonoBehaviour {

    int chara = Chara_Button.chara_select;

    int chapter = Chara_Button.chapter_select;


    void Start () {

        
    }


    void Update()
    {

        //男&&one
        if (chara == 1 && chapter == 1)
        {
            transform.position = new Vector3(-2, 3, 1);
        }
        //男&&two
        if (chara == 1 && chapter == 2)
        {
            transform.position = new Vector3(-2, 0, 1);
        }
        //男&&three
        if (chara == 1 && chapter == 3)
        {
            transform.position = new Vector3(-2, -3, 1);
        }

        //女&&one
        if (chara == 2 && chapter == 1)
        {
            transform.position = new Vector3(2, 3, 1);
        }
        //女&&two
        if (chara == 2 && chapter == 2)
        {
            transform.position = new Vector3(2, 0, 1);
        }
        //女&&three
        if (chara == 2 && chapter == 3)
        {
            transform.position = new Vector3(2, -3, 1);
        }
    }
}
