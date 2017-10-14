using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touch : MonoBehaviour {

    GameObject red;
    GameObject black;

    Vector3 mouse_position;

    private void Start()
    {
        red = GameObject.Find("red");
        black = GameObject.Find("black");
    }

    void Update () {

        
       

	}

    public void OnTriggerEnter2D(Collider2D collision)
    {


    }
}
