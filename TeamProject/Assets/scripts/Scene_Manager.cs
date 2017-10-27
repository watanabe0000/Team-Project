using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour {

	
	void Start () {

       


    }

     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            SceneManager.LoadScene("Stage_Select");

        }
        

        
    }


}
