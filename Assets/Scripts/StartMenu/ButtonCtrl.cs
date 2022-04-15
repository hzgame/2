using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCtrl : MonoBehaviour
{
    public GameObject Guanka;
    public GameObject Shezhi;
    public AudioManager Audio;
    public AudioSource ButtonDownMusic;
    
    private void Awake()
    {
        Audio=GameObject.Find("Main Camera").GetComponent<AudioManager>();
        ButtonDownMusic=GameObject.Find("Main Camera").GetComponent<AudioSource>();
        if(ButtonDownMusic!=null)
        {
            Debug.Log("yes");
        }
    }

    public void PlayGame(){
        Audio.PlayActionSound("Button Down Music");
        SceneManager.LoadScene(1);
    }

    public void SelectGame()
    {
        Audio.PlayActionSound("Button Down Music");
        Guanka.SetActive(true);
    }

    public void Setting()
    {
        Audio.PlayActionSound("Button Down Music");
        Shezhi.SetActive(true);
    }

    public void Savesetting()
    {
        Audio.PlayActionSound("Button Down Music");
        Shezhi.SetActive(false);
    }

    public void AudioSetting()
    {
        //加油..
    }
    
    public void QuitGame(){
         Audio.PlayActionSound("Button Down Music");
        Application.Quit();
    }
}
