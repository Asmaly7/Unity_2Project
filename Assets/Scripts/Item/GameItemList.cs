using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameItemList : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    private GameObject equippedItem;
    public Image interactionImage;

    void Start()
    {
        
        GameObject axe = LoadItem("Axe");
        GameObject sword = LoadItem("Sword");
        GameObject armor = LoadItem("Armor");
        GameObject helmet = LoadItem("Helmet");

        items.Add(axe);
        items.Add(sword);
        items.Add(armor);
        items.Add(helmet);
    }

    GameObject LoadItem(string itemName)
    {
        return Resources.Load<GameObject>("Prefabs/" + itemName); 
    }

    public void EquipItem(int itemIndex)
    {
        if (itemIndex >= 0 && itemIndex < items.Count)
        {

            if (equippedItem != null)
            {
                Destroy(equippedItem);
            }

            equippedItem = Instantiate(items[itemIndex]);
            interactionImage.gameObject.SetActive(true);

        }
    }
    public void UnequipItem()
        {
            
            if (equippedItem != null)
            {
                
                equippedItem = null;

                
                interactionImage.gameObject.SetActive(false);
            }
        }
    
}
