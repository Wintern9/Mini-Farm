using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItemScript : MonoBehaviour
{
    public int Price;
    public int idItem;
    public int NumItem;

    [SerializeField] private InputData inputData;

    private void Start()
    {
        inputData = FindFirstObjectByType<InputData>();
    }

    public void BuyItem()
    {
        int numItemsInInventory = inputData.GetInventoryCells();
        if (InputData.coinValue >= Price && numItemsInInventory < 20)
        {
            InputData.coinValue -= Price;
            inputData.SetInventoryCells(new InventoryCell() { idObject = idItem, numItem = NumItem});
        }
    }
}
