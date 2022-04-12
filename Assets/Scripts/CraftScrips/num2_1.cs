using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num2_1 : MonoBehaviour
{
    public bool ifDestroy = false;
    public bool isBeing = false;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag.Equals("Craft")) isBeing = true;
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.tag.Equals("Craft"))
        {
            if (ifDestroy)
            {
                Destroy(collision.gameObject, 0);
                ifDestroy = false;
                isBeing = false;
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.tag.Equals("Craft"))
        {
            isBeing = false;
            if (GameObject.Find("slot_left").GetComponent<num1_2>().isBeing) GameObject.Find("slot_left").GetComponent<num1_2>().ifDestroy = true;
            if (GameObject.Find("slot_right").GetComponent<num1_2>().isBeing) GameObject.Find("slot_right").GetComponent<num1_2>().ifDestroy = true;
            GameObject.Find("Crafttable_2").GetComponent<CraftMethod_2>().Craftcount = 0;
        }
    }
}
