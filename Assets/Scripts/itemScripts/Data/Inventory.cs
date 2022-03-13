using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New inventory",menuName ="Inventory/New inventory")]
public class Inventory : ScriptableObject
{
    public List<Items> itemsInBag=new List<Items>();
    public List<int>itemsInBagNum=new List<int>();
}
