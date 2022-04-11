using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gameeventsystem : MonoBehaviour
{
    public static Gameeventsystem instance;
    public event Action spellingComplete;
    public bool isSpellingComplete;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
    }

    private void Update()
    {
        GiveItem();
    }

    public void GiveItem()
    {
        //按k模拟汉字拼成事件
        if(Input.GetKeyDown(KeyCode.K)){
            isSpellingComplete=true;
        
            if (spellingComplete != null)
            {
                spellingComplete();
                Debug.Log("bridge is appear");
            }
        }

    }
}
