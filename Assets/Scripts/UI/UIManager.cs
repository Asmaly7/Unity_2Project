using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject Panel;

    public ItemSlot[] itemSlots;

    public void SetInventory()
    {
        for (int i = 0; i < DataManager.instance.gameData.myItems.Length; i++)
        {
            itemSlots[i].Init(DataManager.instance.gameData.myItems[i]);
        }
    }
    

    public void OpenPanel()
    {
        if(Panel != null)
        {                        
            Panel.SetActive(true);            
        }        
    }    

    public void MeinMenu()
    {
        Panel.SetActive(false);
    }  

   

} 