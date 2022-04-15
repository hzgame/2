using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Success : MonoBehaviour
{
    public GameObject tongguan;
    void Start()
    {
        Gameeventsystem.instance.spellingComplete_di+=Succeed;
    }

    public void Succeed(){
        Debug.Log("答案就翻篇");
        tongguan.SetActive(true);
    }
}
