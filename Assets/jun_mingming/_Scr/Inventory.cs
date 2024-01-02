using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> item = new List<Item>();
    public Item currentItem;
    public int currentItemIndex = 0;
    private void Awake()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("1");
            currentItemIndex = 1;
            currentItem.Unequip();
            item[currentItemIndex].Equip();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("2");
            currentItemIndex = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            print("3");
            currentItemIndex = 3;
        }
    }


}
