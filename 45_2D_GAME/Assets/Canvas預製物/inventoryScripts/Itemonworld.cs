using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemonworld : MonoBehaviour
{
    public Item thisItem;
    public Intentory playerInventory;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AddNewItem();
            Destroy(gameObject);
        }
    }
    public void AddNewItem()
    {
        if (!playerInventory.itemList.Contains(thisItem))
        {
            playerInventory.itemList.Add(thisItem);
            //InventoryManager.CreatNewItem(thisItem);
        }
        else
        {
            thisItem.itemHeld += 1;
        }
        InventoryManager.RefreshItem();
    }
}
