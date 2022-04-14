using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftMethod_2 : MonoBehaviour
{
    public int Craftcount;
    public GameObject Target_qiao;
    private GameObject qiao;
    public GameObject Target_chuan;
    /*
     拓展部份格式：
    public GameObject Target_n;
    public GameObject Target_n+1;
     */
    public int slot_up;
    public int slot_down;//创建上下槽位用来检测
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
        }else if(GameObject.Find("slot02")!=null){
            Craft_mode2();
        }else if(GameObject.Find("slot03")!=null){
            Craft_mode3();
        }else if(GameObject.Find("slot04")!=null){
            Craft_mode4();
        }else if(GameObject.Find("slot05")!=null){
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
        qiao.transform.localScale=new Vector3(0.5f,0.5f,0.5f);
        qiao.transform.SetParent(GameObject.Find("inventory_bk").transform);
        qiao.tag = "Crafted";
        Gameeventsystem.instance.isSpellingComplete=true;
        Debug.Log("qiao is created");
    }

    private void craft_chuan()
    {
        Vector3 pos = GameObject.Find("slot02").transform.position;
        Instantiate(Target_chuan, pos, transform.rotation);
        Target_chuan.tag = "Crafted";
    }

    private void Craft_mode1(){
        if (!condition)
        {
            /*
            拓展部份格式 ：
            if (((slot_up == x && slot_down == y)||(slot_up == y && slot_down == x)) && Craftcount == 2)
            {//所有部首的相对位置达成合成文字的条件，可颠倒,Craftcount不必修改
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
            /*
            拓展部份格式 ：
            if (((slot_up == x && slot_down == y)||(slot_up == y && slot_down == x)) && Craftcount == 2)
            {//所有部首的相对位置达成合成文字的条件，可颠倒,Craftcount不必修改
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
               
                if (GameObject.Find("slot02").GetComponent<num2_2>().isBeing) GameObject.Find("slot02").GetComponent<num2_2>().ifDestroy = true;
            }
            condition = true;
        }
    }

    private void Craft_mode3(){
        if (!condition)
        {
            /*
            拓展部份格式 ：
            if (((slot_up == x && slot_down == y)||(slot_up == y && slot_down == x)) && Craftcount == 2)
            {//所有部首的相对位置达成合成文字的条件，可颠倒,Craftcount不必修改
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
                if (GameObject.Find("slot03").GetComponent<num2_3>().isBeing) GameObject.Find("slot03").GetComponent<num2_3>().ifDestroy = true;
            }
            condition = true;
        }
    }

    private void Craft_mode4(){
        if (!condition)
        {
            /*
            拓展部份格式 ：
            if (((slot_up == x && slot_down == y)||(slot_up == y && slot_down == x)) && Craftcount == 2)
            {//所有部首的相对位置达成合成文字的条件，可颠倒,Craftcount不必修改
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
                if (GameObject.Find("slot04").GetComponent<num2_4>().isBeing) GameObject.Find("slot04").GetComponent<num2_4>().ifDestroy = true;
            }
            condition = true;
        }
    }

    private void Craft_mode5(){
        if (!condition)
        {
            /*
            拓展部份格式 ：
            if (((slot_up == x && slot_down == y)||(slot_up == y && slot_down == x)) && Craftcount == 2)
            {//所有部首的相对位置达成合成文字的条件，可颠倒,Craftcount不必修改
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
                if (GameObject.Find("slot05").GetComponent<num2_5>().isBeing) GameObject.Find("slot05").GetComponent<num2_5>().ifDestroy = true;
            }
            condition = true;
        }
    }

}
