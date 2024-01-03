using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> item = new List<Item>();
    public Item currentItem;
    public int currentItemIndex = 0;
    public bool b_enalbeWeaponChange;

    private void Awake()
    {
        
    }
    private void Update()
    {
        if (b_enalbeWeaponChange)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                print("1");
                HandleEquip(1);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                print("2");
                HandleEquip(2);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                print("3");
                HandleEquip(3);
            }
        }
    }
    private void HandleEquip(int a)
    {
        if (currentItemIndex != a)
        {
            Equip(a);
        }
    }
    private void Equip(int a)
    {
        currentItemIndex = a;
        currentItem.Unequip();
        item[currentItemIndex].Equip();
    }

}
