using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gameeventsystem : MonoBehaviour
{
    public static Gameeventsystem instance;
    public event Action spellingComplete_qiao;
    public event Action spellingComplete_chuan;

    public event Action spellingComplete_guo;
    public event Action spellingComplete_di;
    public bool isSpellingComplete_qiao;
    public bool isSpellingComplete_chuan;
    public bool isSpellingComplete_guo;
    public bool isSpellingComplete_di;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        GiveItem_qiao();
        GiveItem_chuan();
        GiveItem_guo();
        GiveItem_di();
    }

    public void GiveItem_qiao()
    {
        //按k模拟汉字拼成事件
        if(isSpellingComplete_qiao==true){
        
            if (spellingComplete_qiao != null)
            {
                spellingComplete_qiao();
                Debug.Log("bridge is appear");
            }
            isSpellingComplete_qiao=false;
        }

    }
    public void GiveItem_chuan(){
        if(isSpellingComplete_chuan==true){
        
            if (spellingComplete_chuan != null)
            {
                spellingComplete_chuan();
                Debug.Log("chuan is appear");
            }
            isSpellingComplete_chuan=false;
        }

    }
    public void GiveItem_guo(){
        if(isSpellingComplete_guo==true){
        
            if (spellingComplete_guo != null)
            {
                spellingComplete_guo();
                Debug.Log("guo is appear");
            }
            isSpellingComplete_guo=false;
        }

    }
    public void GiveItem_di(){
            if(isSpellingComplete_di==true){
        
            if (spellingComplete_di != null)
            {
                spellingComplete_di();
                Debug.Log("di is appear");
            }
            isSpellingComplete_di=false;
        }

    }
}
