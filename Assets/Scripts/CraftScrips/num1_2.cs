using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num1_2 : MonoBehaviour
{
    private int id;
    public bool ifDestroy = false;
    public bool isBeing = false;
    public void OnTriggerEnter(Collider collision)
    {
        isBeing = true;
        /*
        拓展部份格式：
        if (collision.name.Equals("XXX")) id = n;
        */
        if (collision.name.Equals("1")) id = 1;
        if (collision.name.Equals("2")) id = 2;
        if (collision.name.Equals("3")) id = 3;
        if (collision.name.Equals("4")) id = 4;
        if (collision.name.Equals("5")) id = 5;//此部分有待更新，完善部首识别部分后更新
        if (this.gameObject.name.Equals("slot_up")) //此部分用于检测部首插入了哪一个空槽
        {
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_up = id;//传递id值给工作台脚本    
        }
        if (this.gameObject.name.Equals("slot_down"))
        {
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_down = id;
        }
        if (this.gameObject.name.Equals("slot_left"))
        {
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_left = id;
        }
        if (this.gameObject.name.Equals("slot_right"))
        {
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_right = id;
        }
        GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().Craftcount += 1;
        GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().condition = false;
    }
    
    private void OnTriggerExit(Collider collision)
    {//部首移走使位置对应数值归零
        isBeing = false;
        GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().Craftcount -= 1;
        GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().condition = false;
        if (this.gameObject.name.Equals("slot_up"))
        {
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_up = 0;  
        }
        if (this.gameObject.name.Equals("slot_down"))
        {
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_down = 0;
        }
        if (this.gameObject.name.Equals("slot_left"))
        {
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_left = 0;
        }
        if (this.gameObject.name.Equals("slot_right"))
        {
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_right = 0;
        }
    }
    private void OnTriggerStay(Collider collision)
    {//合成成功时，对应位置的部首接收信号执行销毁
        if (ifDestroy)
        {
            if (this.gameObject.name.Equals("slot_up"))
            {
                GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_up = 0;   
            }
            if (this.gameObject.name.Equals("slot_down"))
            {
                GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_down = 0;
            }
            if (this.gameObject.name.Equals("slot_left"))
            {
                GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_left = 0;
            }
            if (this.gameObject.name.Equals("slot_right"))
            {
                GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_right = 0;
            }
            Destroy(collision.gameObject, 0);
            ifDestroy = false;
        }
    }
}
