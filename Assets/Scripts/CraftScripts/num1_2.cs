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
        Debug.Log("AAAAAAAAA");
        /*
        拓展部份格式：
        if (collision.name.Equals("XXX")) id = n;
        */
        if (collision.name.Equals("木字旁")) id = 1;
        if (collision.name.Equals("乔")) id = 2;
        if (collision.name.Equals("舟")) id = 3;
        if (collision.name.Equals("沿")) id = 4;
        if (collision.name.Equals("竹字头")) id = 5;
        if (collision.name.Equals("由")) id = 6;
        if (collision.name.Equals("走之")) id = 7;
        if (collision.name.Equals("寸")) id = 8;
        if (this.gameObject.name.Equals("slot_up")) 
        {
            CraftMethod_2.instance.slot_up = id;
        }
        if (this.gameObject.name.Equals("slot_down"))
        {
            CraftMethod_2.instance.slot_down = id;
        }
        if (this.gameObject.name.Equals("slot_left"))
        {
            CraftMethod_2.instance.slot_left = id;
            Debug.Log(CraftMethod_2.instance.slot_left);
        }
        if (this.gameObject.name.Equals("slot_right"))
        {
            CraftMethod_2.instance.slot_right = id;
        }
        if (this.gameObject.name.Equals("slot_up2"))
        {
            CraftMethod_2.instance.slot_up2 = id;
        }
        if (this.gameObject.name.Equals("slot_down2"))
        {
            CraftMethod_2.instance.slot_down2 = id;
        }
        if (this.gameObject.name.Equals("slot_left2"))
        {
            CraftMethod_2.instance.slot_left2 = id;
        }
        if (this.gameObject.name.Equals("slot_right2"))
        {
            CraftMethod_2.instance.slot_right2 = id;
        }
        if (this.gameObject.name.Equals("slot_middle"))
        {
            CraftMethod_2.instance.slot_middle = id;
        }
        if (this.gameObject.name.Equals("slot_middle2"))
        {
            CraftMethod_2.instance.slot_middle2 = id;
        }
        if (this.gameObject.name.Equals("slot_outer"))
        {
            CraftMethod_2.instance.slot_outer = id;
             Debug.Log(CraftMethod_2.instance.slot_outer);
        }
        if (this.gameObject.name.Equals("slot_inner"))
        {
            CraftMethod_2.instance.slot_inner = id;
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
        if (this.gameObject.name.Equals("slot_up2"))
        {
            CraftMethod_2.instance.slot_up2 = 0;
        }
        if (this.gameObject.name.Equals("slot_down2"))
        {
            CraftMethod_2.instance.slot_down2 = 0;
        }
        if (this.gameObject.name.Equals("slot_left2"))
        {
            CraftMethod_2.instance.slot_left2 = 0;
        }
        if (this.gameObject.name.Equals("slot_right2"))
        {
            CraftMethod_2.instance.slot_right2 = 0;
        }
        if (this.gameObject.name.Equals("slot_middle"))
        {
            CraftMethod_2.instance.slot_middle = 0;
        }
        if (this.gameObject.name.Equals("slot_middle2"))
        {
            CraftMethod_2.instance.slot_middle2 = 0;
        }
        if (this.gameObject.name.Equals("slot_outer"))
        {
            CraftMethod_2.instance.slot_outer = 0;
        }
        if (this.gameObject.name.Equals("slot_inner"))
        {
            CraftMethod_2.instance.slot_inner = 0;
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
            if (this.gameObject.name.Equals("slot_up2"))
            {
                CraftMethod_2.instance.slot_up2 = 0;
            }
            if (this.gameObject.name.Equals("slot_down2"))
            {
                CraftMethod_2.instance.slot_down2 = 0;
            }
            if (this.gameObject.name.Equals("slot_left2"))
            {
                CraftMethod_2.instance.slot_left2 = 0;
            }
            if (this.gameObject.name.Equals("slot_right2"))
            {
                CraftMethod_2.instance.slot_right2 = 0;
            }
            if (this.gameObject.name.Equals("slot_middle"))
            {
                CraftMethod_2.instance.slot_middle = 0;
            }
            if (this.gameObject.name.Equals("slot_middle2"))
            {
                CraftMethod_2.instance.slot_middle2 = 0;
            }
            if (this.gameObject.name.Equals("slot_outer"))
            {
                CraftMethod_2.instance.slot_outer = 0;
            }
            if (this.gameObject.name.Equals("slot_inner"))
            {
                CraftMethod_2.instance.slot_inner = 0;
            }
            Destroy(collision.gameObject, 0);
            ifDestroy = false;
        }
    }
}
