using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;//单例模式
    public bool isPaused;
    public List<Items> itemsInBag=new List<Items>();//背包物品的列表
    public List<int>itemsInBagNum=new List<int>();//背包物品数量的列表，与背包物品的列表编号相对应，即itemsInBag[1]代表的物品的数量是intemsInBagNum[1]，依次类推
    public GameObject[] slots;//此为背包物品栏
    public GameObject guo;
    public GameObject player;
    public GameObject house;
    private float _Distance;
    public float _Dis
    {
        get
        {
            return _Distance;
        }
    }

    private void Awake()
    {
        //初始化单例
        if(instance!=null){
            Destroy(gameObject);
        }
        instance=this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        DisplayItem();
        //house = GameObject.Find("Box002");
    }
    private void Update()
    {
        GameState();
        _Distance=Vector3.Distance(house.transform.position, player.transform.position);
    }
    
    private void GameState(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused==false){
                Pause();
            }
            else{
                Resume();
            }

        }
    }//按下esc键就可暂停，再按继续

    private void Resume(){
        Time.timeScale=1;
        isPaused=false;
    }

    private void Pause(){
        Time.timeScale=0;
        isPaused=true;
    }

    public void DisplayItem(){
        for(int i=0;i<itemsInBag.Count;i++){
            slots[i].transform.GetChild(0).GetComponent<Image>().color=new Color(1,1,1,1);
            slots[i].transform.GetChild(0).GetComponent<Image>().sprite=itemsInBag[i].itemImage;
            slots[i].transform.GetChild(0).GetComponent<Transform>().name=itemsInBag[i].itemName;

            slots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().color=new Color(1,1,1,1);
            slots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=itemsInBagNum[i].ToString();
        }
    }//显示背包栏中的物品及数量，每捡到一个东西就刷新一次

}