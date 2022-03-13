using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOnWorld : MonoBehaviour
{
    public Items thisItem;
    public Inventory playerInventory;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            AddItem();
            Destroy(gameObject);
        }
    }

    private void AddItem(){
        if(!GameManager.instance.itemsInBag.Contains(thisItem)){
            GameManager.instance.itemsInBag.Add(thisItem);
            GameManager.instance.itemsInBagNum.Add(1);
        }
        else{
            for(int i=0;i<GameManager.instance.itemsInBag.Count;i++){
                if(thisItem==GameManager.instance.itemsInBag[i]){
                        thisItem.itemNum+=1;
                        GameManager.instance.itemsInBagNum[i]+=1;
                    }
            }
        }
        GameManager.instance.DisplayItem();
    }
}
