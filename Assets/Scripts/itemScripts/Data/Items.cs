using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="New item",menuName ="Inventory/New item")]
public class Items : ScriptableObject
{
   public int itemID;
   public string itemName;
   public int itemNum;
   [TextArea]
   public string itemInfo;
   public Sprite itemImage;

}
