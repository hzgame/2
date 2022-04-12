using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftMethod_2 : MonoBehaviour
{
    public int Craftcount;
    public GameObject Target_qiao;
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
    public bool condition = false; //为了让文字只生成一次

    void Update()
    {
        if (!condition)
        {
            /*
            拓展部份格式 ：
            if (((slot_up == x && slot_down == y)||(slot_up == y && slot_down == x)) && Craftcount == 2)
            {//所有部首的相对位置达成合成文字的条件，可颠倒,Craftcount不必修改
                craft_XXX();
            }
            */
            if ((slot_up == 1 && slot_down == 2 ) && Craftcount == 2)
            {
                craft_qiao();
            }
            if ((slot_left == 3 && slot_right == 4) && Craftcount == 2) 
            {
                craft_chuan();    
            }
            else
            {
                if (GameObject.Find("slot01").GetComponent<num2_2>().isBeing) GameObject.Find("slot01").GetComponent<num2_2>().ifDestroy = true;
                if (GameObject.Find("slot02").GetComponent<num2_2>().isBeing) GameObject.Find("slot02").GetComponent<num2_2>().ifDestroy = true;
            }
            condition = true;
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
        Instantiate(Target_qiao, pos, transform.rotation);
    }

    private void craft_chuan()
    {
        Vector3 pos = GameObject.Find("slot02").transform.position;
        Instantiate(Target_chuan, pos, transform.rotation);
    }
}
