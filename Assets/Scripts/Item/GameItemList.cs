using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;


[CreateAssetMenu(fileName = "ItemData_", menuName ="Data/ItemData", order = 0)]
public class GameItemList : ScriptableObject
{
    public string itemName;
    public int price;
    public bool isEquiped;
    public Sprite image;
    

   
    
}
