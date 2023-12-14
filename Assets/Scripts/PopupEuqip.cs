using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class PopupEuqip : MonoBehaviour
{
    public TMP_Text infoText;
    public Button confirmBtn;

    public void PopupSetting(ItemSlot slot)
    {
        if (slot.InputData.isEquiped)
        {
            infoText.text = "Unequip?";
            confirmBtn.onClick.RemoveAllListeners();
            confirmBtn.onClick.AddListener(() => 
            {
                slot.InputData.isEquiped = false;
                slot.ChangeEquip();
            });
        }

        else
        {
            infoText.text = "Euqip?";
            confirmBtn.onClick.RemoveAllListeners();
            confirmBtn.onClick.AddListener(() => 
            {
                slot.InputData.isEquiped = true;
                slot.ChangeEquip();
            });
        }


    }

}
