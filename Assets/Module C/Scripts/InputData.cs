using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputData : DataController
{
    List<InventoryCell> inventoryCells;
    [SerializeField] InventoryController inventoryController;
    static public int coinValue;
    static public int Exp;
    static public int Level;

    static public int inventoryCellsCount;

    void Start()
    {
        if (!PlayerPrefs.HasKey($"{inventoryDataKey}.id.0")) {
            FirstLoadGame();
        } else {
            inventoryCells = LoadInventoryData();
            coinValue = LoadIntData(moneyDataKey);
            Exp = LoadIntData(expDataKey);
            Level = LoadIntData(levelDataKey);
        }

        inventoryController.SetSpritesItem(inventoryCells); 
    }

    private void Update()
    {
        inventoryCellsCount = inventoryCells.Count;
        inventoryController.SetSpritesItem(inventoryCells);
    }

    public int GetInventoryCells()
    {
        return inventoryCells.Count;
    }

    public void SetInventoryCells(InventoryCell inventoryCell)
    {
        inventoryCells.Add(inventoryCell);
        SaveInventoryData(inventoryCells);
        SaveIntData(moneyDataKey, coinValue);
    }

    void FirstLoadGame()
    {
        inventoryCells = new List<InventoryCell>() { new InventoryCell() { idObject = 1, numItem = 100 }, new InventoryCell() { idObject = 2, numItem = 100 }, new InventoryCell() { idObject = 3, numItem = 3 } };
        coinValue = 100;
        Level = 1;
        Exp = 0;

        SaveInventoryData(inventoryCells);
        SaveIntData(moneyDataKey, coinValue);
        SaveIntData(levelDataKey, coinValue);
        SaveIntData(expDataKey, coinValue);
    }
}
