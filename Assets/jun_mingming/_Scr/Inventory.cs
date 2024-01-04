using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class Inventory : MonoSingleton<Inventory>
{
    public List<Item> item = new List<Item>();
    public int currentItemIndex = 0;
    public bool b_enalbeWeaponChange;
    public Transform itemOffset;
    protected override void Awake()
    {
        base.Awake();
        currentItemIndex = 0;
        item[currentItemIndex].Equip();
    }
    private void Update()
    {
        if (b_enalbeWeaponChange)//»ç¶ûÈ÷
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                HandleWeaponChange(0);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                HandleWeaponChange(1);
            }
            //else if (Input.GetKeyDown(KeyCode.Alpha3))
            //{
            //    HandleWeaponChange(2);
            //}

        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            item[currentItemIndex].Interaction0();
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            item[currentItemIndex].Interaction1();
        }
    }
    public void HandleWeaponChange(int a)
    {
        if (currentItemIndex != a && item.Count > a)
        {
            WeaponChange(a);
        }
    }
    public void WeaponChange(int a)
    {
        item[currentItemIndex].Unequip();
        currentItemIndex = a;
        item[currentItemIndex].Equip();
    }
    public void AddItem(Item itema)
    {
        item.Add(itema);
        itema.transform.SetParent(itemOffset);
        itema.transform.localPosition = itema.offset;
        itema.gameObject.SetActive(false);
    }
    public void RemoveItem(Item itema)//unfinished
    {
        item.Remove(itema);
    }
    public void RemoveItem(int index)
    {
        item.RemoveAt(index);
    }

}
