using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerctrl : MonoBehaviour
{
    public static Playerctrl instance;
    [SerializeField]
    private bool isSepllingComplete;
    
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
    }

    void Update()
    {
        Give();
    }

    public void Give()
    {
        if (Input.GetKeyDown("k"))
        {
            isSepllingComplete = true;
            Gameeventsystem.instance.GiveItem();
        }
    }

}
