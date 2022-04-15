using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public GameObject Player_Boat,Player,Main_camera,Camera02;
    void Start()
    {
        Gameeventsystem.instance.spellingComplete_chuan += BoatAppear;
    }

    private void BoatAppear()
    {
        Debug.Log("上船喽");
        Player.SetActive(false);
        Player_Boat.SetActive(true);
        Main_camera.SetActive(false);
        Camera02.SetActive(true);
    }
}
