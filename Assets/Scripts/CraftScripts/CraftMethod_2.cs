using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftMethod_2 : MonoBehaviour
{
    public int Craftcount;
    public GameObject Target_qiao;
    public GameObject Target_chuan;
    public GameObject Target_di;
    public GameObject Target_guo;
    [HideInInspector] public GameObject qiao;
    [HideInInspector] public GameObject chuan;
    [HideInInspector] public GameObject di;
    [HideInInspector] public GameObject guo;
    public int slot_up;
    public int slot_down;//创建槽位
    public int slot_left;
    public int slot_right;
    public int slot_up2;
    public int slot_down2;
    public int slot_left2;
    public int slot_right2;
    public int slot_middle;
    public int slot_middle2;
    public int slot_outer;
    public int slot_inner;
    public bool condition = false; //为了让文字只生成一次

    public static CraftMethod_2 instance;
    private void Awake()
    {
        //初始化单例
        if(instance!=null){
            Destroy(gameObject);
        }
        instance=this;
    }
    void Update()
    {
        if(GameObject.Find("slot01")!=null){
            Craft_mode1();
        }
        else if(GameObject.Find("slot02")!=null){
            Craft_mode2();
        }
        else if(GameObject.Find("slot03")!=null){
            Craft_mode3();
        }
        else if(GameObject.Find("slot04")!=null){
            Craft_mode4();
        }
        else if(GameObject.Find("slot05")!=null){
            Craft_mode5();
        }

    }

    /*
     拓展部份格式：
     private void craft_XXX() {//合成文字“XXX”
        Vector3 pos = GameObject.Find("slot").transform.position;
        Instantiate(Target_n, pos, transform.rotation);
    }*/

    private void craft_qiao()
    {
        Vector3 pos = GameObject.Find("slot01").transform.position;
        qiao=Instantiate(Target_qiao, pos, transform.rotation);
        qiao.SetActive(true);
        qiao.transform.SetParent(GameObject.Find("inventory1").transform);
        qiao.tag = "Crafted";
        Gameeventsystem.instance.isSpellingComplete_qiao=true;
        Debug.Log("qiao is created");
    }

    private void craft_chuan()
    {
        Vector3 pos = GameObject.Find("slot01").transform.position;
        chuan=Instantiate(Target_chuan, pos, transform.rotation);
        chuan.SetActive(true);
        chuan.transform.SetParent(GameObject.Find("inventory1").transform);
        chuan.tag = "Crafted";
        Gameeventsystem.instance.isSpellingComplete_chuan = true;
        Debug.Log("chuan is created");
    }

    private void craft_di()
    {
        Vector3 pos = GameObject.Find("slot02").transform.position;
        di=Instantiate(Target_di, pos, transform.rotation);
        di.SetActive(true);
        di.transform.SetParent(GameObject.Find("inventory1").transform);
        di.tag = "Crafted";
        Gameeventsystem.instance.isSpellingComplete_di = true;
        Debug.Log("di is created");
    }

    private void craft_guo()
    {
        Debug.Log("guo is created");
        Vector3 pos = GameObject.Find("slot05").transform.position;
        guo=Instantiate(Target_guo, pos, transform.rotation);
        guo.SetActive(true);
        guo.transform.SetParent(GameObject.Find("inventory1").transform);
        guo.tag = "Crafted";
        Gameeventsystem.instance.isSpellingComplete_guo = true;
        
    }



    private void Craft_mode1(){
        if (!condition)
        {
            /*
            拓展部份格式 ：
            if ((slot_up == x && slot_down == y) && Craftcount == 2)
            {//所有部首的相对位置达成合成文字的条件，Craftcount不必修改
                craft_XXX();
            }
            */
            if ((slot_left == 1 && slot_right == 2 ) && Craftcount == 2)
            {
                craft_qiao();
            }
            if ((slot_left == 3 && slot_right == 4) && Craftcount == 2) 
            {
                craft_chuan();
            }
            else
            {
                if (GameObject.Find("slot01").GetComponent<num2_1>().isBeing) GameObject.Find("slot01").GetComponent<num2_1>().ifDestroy = true;
            }
            condition = true;
        }
    }
    
    private void Craft_mode2(){
        if (!condition)
        {
            if ((slot_up == 5 && slot_down == 6) && Craftcount == 2) 
            {
                craft_di();
            }
            else
            {
               
                if (GameObject.Find("slot02").GetComponent<num2_2>().isBeing) GameObject.Find("slot02").GetComponent<num2_2>().ifDestroy = true;
            }
            condition = true;
        }
    }

    private void Craft_mode3(){
        if (!condition)
        {
            if ((slot_left == 1 && slot_right == 2 ) && Craftcount == 2)
            {
                Debug.Log("NULL");
            }
            else
            {
                if (GameObject.Find("slot03").GetComponent<num2_3>().isBeing) GameObject.Find("slot03").GetComponent<num2_3>().ifDestroy = true;
            }
            condition = true;
        }
    }

    private void Craft_mode4(){
        if (!condition)
        {
            if ((slot_left == 1 && slot_right == 2 ) && Craftcount == 2)
            {
                Debug.Log("NULL");
            }
            else
            {
                if (GameObject.Find("slot04").GetComponent<num2_4>().isBeing) GameObject.Find("slot04").GetComponent<num2_4>().ifDestroy = true;
            }
            condition = true;
        }
    }

    private void Craft_mode5(){
        if (!condition)
        {
            if ((slot_outer == 7 && slot_inner == 8) && Craftcount == 2) 
            {
                craft_guo();
            }
            else
            {
                if (GameObject.Find("slot05").GetComponent<num2_5>().isBeing) GameObject.Find("slot05").GetComponent<num2_5>().ifDestroy = true;
            }
            condition = true;
        }
    }

}