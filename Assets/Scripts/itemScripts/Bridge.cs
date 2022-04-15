using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public GameObject bridge,obstacle;

    void Start()
    {
        //订阅事件
        Gameeventsystem.instance.spellingComplete_qiao+=BridgeAppear;
    }

    void Update()
    {
        
    }
      private void BridgeAppear()
    {
        bridge.SetActive(true);
        obstacle.SetActive(false);
    }


}
