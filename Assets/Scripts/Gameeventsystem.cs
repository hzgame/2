using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gameeventsystem : MonoBehaviour
{
    public static Gameeventsystem instance;
    public event Action spellingComplete;

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
