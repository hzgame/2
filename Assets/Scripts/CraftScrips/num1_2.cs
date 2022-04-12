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
        ��չ���ݸ�ʽ��
        if (collision.name.Equals("XXX")) id = n;
        */
        if (collision.name.Equals("1")) id = 1;
        if (collision.name.Equals("2")) id = 2;
        if (collision.name.Equals("3")) id = 3;
        if (collision.name.Equals("4")) id = 4;
        if (collision.name.Equals("5")) id = 5;//�˲����д����£����Ʋ���ʶ�𲿷ֺ����
        if (this.gameObject.name.Equals("slot_up")) //�˲������ڼ�ⲿ�ײ�������һ���ղ�
        {
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().slot_up = id;//����idֵ������̨�ű�    
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
    {//��������ʹλ�ö�Ӧ��ֵ����
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
    {//�ϳɳɹ�ʱ����Ӧλ�õĲ��׽����ź�ִ������
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
