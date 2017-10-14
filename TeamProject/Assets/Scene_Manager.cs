using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour {

	
	void Start () {

        GameObject chara_red = GameObject.Find("赤");
        GameObject chara_black = GameObject.Find("黒");

        chara_red.SetActive(true);
        chara_black.SetActive(true);


    }

     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            SceneManager.LoadScene("Stage_Select");

        }
        if (Input.GetMouseButtonDown(1))
        {
            
        }

        
    }


}
