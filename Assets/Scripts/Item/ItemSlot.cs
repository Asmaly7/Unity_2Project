using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [HideInInspector]public GameItemList InputData;

    public PopupEuqip popupEuqip;
    public Image itemImage;
    public GameObject EquipMark;

    public void Init(GameItemList data)
    {
        InputData = data;
        itemImage.sprite = data.image;
        itemImage.enabled = true;

        ChangeEquip();
    }

    public void ChangeEquip()
    {
        if (InputData.isEquiped)
        {
            EquipMark.SetActive(true);
        }
        else
        {
            EquipMark.SetActive(false);
        }
    }

    public void Popup()
    {
        popupEuqip.PopupSetting(this);
    }
}
