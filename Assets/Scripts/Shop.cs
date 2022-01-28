using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shop : MonoBehaviour
{
    public float star;
    public float coin;
    public float potion;
    public string name;
    public bool isSelected;
    public GameObject[] coinGrade;
    public Vector3 defaultScale = Vector3.one;

    void Start()
    {
        star = 0;
        coin = 0;
        potion = 0;
    }

    void Update()
    {
        if (!isSelected) return;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActiveCoins(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActiveCoins(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActiveCoins(3);
        }
        
    }

    public void select()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }

    public void deselect()
    {
        transform.localScale = defaultScale;
    }
    private void ActiveCoins(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            coinGrade[i].SetActive(true);
        }
    }
}