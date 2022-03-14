using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//此脚本目前尚未投入使用，可忽略
public class Waterctrl : MonoBehaviour
{
    void Awake()
    {
        transform.position += new Vector3(-10, -10, -10);
    }

    void Start()
    {
        Gameeventsystem.instance.spellingComplete += GiveWater;
    }

    public void GiveWater()
    {
        transform.position += new Vector3(10, 10, 10);
    }
   
}
