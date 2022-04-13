using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num1_2 : MonoBehaviour
{
    private int id;
    public bool ifDestroy = false;
    public bool isBeing = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        isBeing = true;
        /*
        拓展部份格式：
        if (collision.name.Equals("XXX")) id = n;
        */
        if (collision.name.Equals("mu_zi_pang")) id = 1;
        if (collision.name.Equals("qiao")) id = 2;
        if (collision.name.Equals("3")) id = 3;
        if (collision.name.Equals("4")) id = 4;
        if (collision.name.Equals("5")) id = 5;//此部分有待更新，完善部首识别部分后更新
        if (this.gameObject.name.Equals("slot_up")) //此部分用于检测部首插入了哪一个空槽
        {
            CraftMethod_2.instance.slot_up = id;//传递id值给工作台脚本    
        }
        if (this.gameObject.name.Equals("slot_down"))
        {
            CraftMethod_2.instance.slot_down = id;
        }
        if (this.gameObject.name.Equals("slot_left"))
        {
            CraftMethod_2.instance.slot_left = id;
        }
        if (this.gameObject.name.Equals("slot_right"))
        {
            CraftMethod_2.instance.slot_right = id;
        }
        CraftMethod_2.instance.Craftcount += 1;
        CraftMethod_2.instance.condition = false;
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {//部首移走使位置对应数值归零
        isBeing = false;
        CraftMethod_2.instance.Craftcount -= 1;
        CraftMethod_2.instance.condition = false;
        if (this.gameObject.name.Equals("slot_up"))
        {
            CraftMethod_2.instance.slot_up = 0;  
        }
        if (this.gameObject.name.Equals("slot_down"))
        {
            CraftMethod_2.instance.slot_down = 0;
        }
        if (this.gameObject.name.Equals("slot_left"))
        {
            CraftMethod_2.instance.slot_left = 0;
        }
        if (this.gameObject.name.Equals("slot_right"))
        {
            CraftMethod_2.instance.slot_right = 0;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {//合成成功时，对应位置的部首接收信号执行销毁
        if (ifDestroy)
        {
            if (this.gameObject.name.Equals("slot_up"))
            {
                CraftMethod_2.instance.slot_up = 0;   
            }
            if (this.gameObject.name.Equals("slot_down"))
            {
                CraftMethod_2.instance.slot_down = 0;
            }
            if (this.gameObject.name.Equals("slot_left"))
            {
                CraftMethod_2.instance.slot_left = 0;
            }
            if (this.gameObject.name.Equals("slot_right"))
            {
                CraftMethod_2.instance.slot_right = 0;
            }
            Destroy(collision.gameObject, 0);
            ifDestroy = false;
        }
    }
}
