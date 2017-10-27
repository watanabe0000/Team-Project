using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Chara_Button : MonoBehaviour {
    //右キャラ
    [SerializeField]
    private Image Right;
    //左キャラ
    [SerializeField]
    private Image Left;
    //キャラテキスト
    [SerializeField]
    private Text Chara_Text;

    

    //章選択：１章
    [SerializeField]
    private Image one_but;
    //章選択：２章
    [SerializeField]
    private Image two_but;
    //章選択：３章
    [SerializeField]
    private Image three_but;
    //章選択テキスト
    [SerializeField]
    private Text Chapter_Text;
  
    //タッチした時の音
    public GameObject pick_soundPrefab;

    
    public static int chara_select = 0;
    public static int chapter_select = 0;


  public void Start()
    {   //初期化

        Left.enabled = false;
        Right.enabled = false;
        Chara_Text.enabled = false;

        
        
    }

    //左キャラタッチで選択
    public void Left_character()
    {


        //右ボタン
        Right.enabled = false;
        //左ボタン
        Left.enabled = false;
        //キャラ選択テキスト
        Chara_Text.enabled = false;

        //SE再生
        GameObject pick_sound = Instantiate(pick_soundPrefab,
                                transform.position, Quaternion.identity);

        chara_select = 1;

        SceneManager.LoadScene("Clear");

    }
    //右キャラタッチで選択
    public void Right_character()
    {
        Right.enabled = false;
       Left.enabled = false;
        Chara_Text.enabled = false;

        GameObject pick_sound = Instantiate(pick_soundPrefab, 
                                transform.position, Quaternion.identity);

        chara_select = 2;

        SceneManager.LoadScene("Clear");


    }


  
    public void one()
    {
        one_but.enabled = false;
        two_but.enabled = false;
        three_but.enabled = false;
        Chapter_Text.enabled = false;


        Left.enabled = true;
        Right.enabled = true;
        Chara_Text.enabled = true;

        chapter_select = 1;

        GameObject pick_sound = Instantiate(pick_soundPrefab,
                                transform.position, Quaternion.identity);
    }

    public void two()
    {
        one_but.enabled = false;
        two_but.enabled = false;
        three_but.enabled = false;
        Chapter_Text.enabled = false;

        Left.enabled = true;
        Right.enabled = true;
        Chara_Text.enabled = true;

        chapter_select = 2;

        GameObject pick_sound = Instantiate(pick_soundPrefab, 
                                transform.position, Quaternion.identity);
    }
    public void three()
    {
        one_but.enabled = false;
        two_but.enabled = false;
        three_but.enabled = false;
        Chapter_Text.enabled = false;

        Left.enabled = true;
        Right.enabled = true;
        Chara_Text.enabled = true;

        chapter_select = 3;

        GameObject pick_sound = Instantiate(pick_soundPrefab,
                                transform.position, Quaternion.identity);

    }


}
