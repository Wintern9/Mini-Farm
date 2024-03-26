using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputData : MonoBehaviour
{
    List<InventoryCell> inventoryCells;
    [SerializeField] InventoryController inventoryController;
    static public int coinValue = 100;
    static public int Exp = 0;
    static public int Level = 1;

    void Start()
    {
        inventoryCells = new List<InventoryCell>() { new InventoryCell() { idObject = 1, numItem = 100}, new InventoryCell() { idObject = 2, numItem = 100}, new InventoryCell() { idObject = 3, numItem = 3 } };
        inventoryController.SetSpritesItem(inventoryCells);
    }

    private void Update()
    {
        inventoryController.SetSpritesItem(inventoryCells);
    }

    public int GetInventoryCells()
    {
        return inventoryCells.Count;
    }

    public void SetInventoryCells(InventoryCell inventoryCell)
    {
        inventoryCells.Add(inventoryCell);
    }
}
