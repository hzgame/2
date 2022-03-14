using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//游戏事件管理系统
public class Gameeventsystem : MonoBehaviour
{
    public static Gameeventsystem instance;
    public event Action spellingComplete;//拼写结束事件

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
    }

    public void GiveItem()
    {
        if (spellingComplete != null)
        {
            spellingComplete();
        }

    }
}
