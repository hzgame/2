using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num2_4 : MonoBehaviour
{
    public bool ifDestroy = false;
    public bool isBeing = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Crafted")) isBeing = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Crafted"))
        {
            if (ifDestroy)
            {
                Destroy(collision.gameObject, 0);
                ifDestroy = false;
                isBeing = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("Crafted"))
        {
            isBeing = false;
            if (GameObject.Find("slot_left2").GetComponent<num1_2>().isBeing) GameObject.Find("slot_left2").GetComponent<num1_2>().ifDestroy = true;
            if (GameObject.Find("slot_right2").GetComponent<num1_2>().isBeing) GameObject.Find("slot_right2").GetComponent<num1_2>().ifDestroy = true;
            if (GameObject.Find("slot_middle").GetComponent<num1_2>().isBeing) GameObject.Find("slot_middle").GetComponent<num1_2>().ifDestroy = true;
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().Craftcount = 0;
            collision.tag = "Untagged";
        }
    }
}
