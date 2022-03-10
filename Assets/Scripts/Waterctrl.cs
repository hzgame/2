using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
