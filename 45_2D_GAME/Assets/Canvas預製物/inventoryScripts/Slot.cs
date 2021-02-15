using UnityEngine.UI;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public Item slotItem;
    public Image slotImage;
    public Text slotNum;

    public void ItemOnClicked()
    {
        InventoryManager.UpdateItemInfo(slotItem.iteminfo);
    }
}
