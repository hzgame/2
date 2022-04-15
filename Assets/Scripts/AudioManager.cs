using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource bg_music_player;//背景音乐播放
    public AudioSource action_music_player;//音效播放
    public AudioClip au;
    public AudioClip boubleSound;
    public AudioClip successAudio;

    private void Awake()
    {
        Instance = this;
    }
    
    private void  Start()
    {
       PlayBgMusic("bg_music_player");
       MouseManager.Instance.OnMouseClicked_Buoble+=PlayBoubleAudio;
       //Gameeventsystem.instance.spellingComplete_di+=PlaySuccess;
       
    }
    public void PlayBgMusic(string name)
    {
        if (!bg_music_player.isPlaying)
        {
            AudioClip audioClip = Resources.Load<AudioClip>(name);
            bg_music_player.clip = audioClip;
            bg_music_player.Play();
        }
        else
        {
            Debug.LogError("正在播放中不能切换");
        }

    }

    public void StopBgMusic()
    {
        if (bg_music_player.isPlaying)
        {
            bg_music_player.Stop();
        }
    }

    public void PlayActionSound(string name)
    {
        //AudioClip audioClip = Resources.Load<AudioClip>(name);
        AudioClip audioClip = au;
        action_music_player.clip=audioClip;
        if(action_music_player.clip!=null)
        {
            Debug.Log("ajndakn");
        }
        action_music_player.Play();
        Debug.Log("can paly");
        //action_music_player.PlayOneShot(audioClip);
    }


    public void StopActionSound(string name)
    {
        action_music_player.Stop();
    }

    public void PlayButtonAudio(){
        AudioClip audioClip = au;
        action_music_player.clip=audioClip;
        action_music_player.Play();
    }

    public void PlayBoubleAudio(Vector3 no){
        AudioClip audioClip = boubleSound;
        action_music_player.clip=audioClip;
        action_music_player.Play();
    }

    public void PlaySuccess(){
        AudioClip audioClip = successAudio;
        action_music_player.clip=audioClip;
        action_music_player.Play();
    }
}


//使用方法：将此脚本挂载在摄像机，需要音效的地方在脚本里加一句GameObject.Find("摄像机名").GetComponent<AudioManager>()./*方法名例如*/PlayBgMusic("文件名")来调用播放方法
//尚未测试
//音频文件的格式貌似要转换到WAV，可以用格式工厂转换一下