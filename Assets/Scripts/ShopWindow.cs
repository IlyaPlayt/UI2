using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopWindow : MonoBehaviour
{
    public InputField NameInpute;
    public Slider coin;
    public Slider star;
    public Slider potion;
    public Shop curentshop;
    public GameObject mapPin;
    

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void deselectShop()
    {
        if (curentshop != null)
        {
            mapPin.SetActive(false); 
            curentshop.deselect();
            gameObject.SetActive(false);
            curentshop.isSelected = false;
            curentshop.isSelected = false;
            curentshop.coin = coin.value * 100;
            curentshop.star = star.value * 100;
            curentshop.potion = potion.value * 100;
            curentshop.name = NameInpute.text;
            curentshop = null;
            
        }
    }

    public void selectShop(Shop shop)
    {
        curentshop = shop;
        mapPin.SetActive(true);
        mapPin.transform.position = curentshop.transform.position;
        curentshop.select();
        curentshop.isSelected = true;
        coin.value = curentshop.coin / 100;
        star.value = curentshop.star / 100;
        potion.value = curentshop.potion / 100;
        NameInpute.text = curentshop.name;
        gameObject.SetActive(true);
    }
}