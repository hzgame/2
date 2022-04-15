using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoLand : MonoBehaviour
{
    public static GoLand instance;
    public GameObject Player02,Player_Boat,Camera02,Camera03,texiao;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("zhuangshang!");
            Player02.SetActive(true);
            Player_Boat.SetActive(false);
            Camera03.SetActive(true);
            Camera02.SetActive(false);
            texiao.SetActive(false);
        }
    }
}
