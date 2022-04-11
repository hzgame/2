using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public GameObject bridge;

    void Start()
    {
        //订阅事件
        Gameeventsystem.instance.spellingComplete+=BridgeAppear;
    }

    void Update()
    {
        
    }
      private void BridgeAppear()
    {
        bridge.SetActive(true);
    }


}
