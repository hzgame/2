using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//注意此脚本为存储仓库数据而生，目前尚未投入使用。

[CreateAssetMenu(fileName ="New inventory",menuName ="Inventory/New inventory")]
public class Inventory : ScriptableObject
{
    public List<Items> itemsInBag=new List<Items>();
    public List<int>itemsInBagNum=new List<int>();
}
