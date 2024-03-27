using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    public string inventoryDataKey = "inventoryDataKey";
    public string moneyDataKey = "moneyDataKey";
    public string levelDataKey = "levelDataKey";
    public string expDataKey = "expDataKey";
    public string positionPlayerDataKey = "positionPlayerDataKey";

    private void Awake()
    {
        inventoryDataKey = "inventoryDataKey";
    }

    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void SaveInventoryData(List<InventoryCell> inventoryCells)
    {
        int index = 0;
        foreach(InventoryCell cell in inventoryCells)
        {
            SaveIntData($"{inventoryDataKey}.id.{index}", cell.idObject);
            SaveIntData($"{inventoryDataKey}.num.{index}", cell.numItem);
            index++;
        }
    }

    public List<InventoryCell> LoadInventoryData()
    {
        List <InventoryCell> inventoryCells = new List <InventoryCell>();

        for(int i = 0; i< 20; i++)
        {
            if (PlayerPrefs.HasKey($"{inventoryDataKey}.id.{i}"))
            {
                inventoryCells.Add(new InventoryCell() { idObject = LoadIntData($"{inventoryDataKey}.id.{i}"), numItem = LoadIntData($"{inventoryDataKey}.num.{i}")});
            } else
            {
                break;
            }
        }
        return inventoryCells;
    }

    public void SavePositionPlayerData(float x, float y)
    {
        SaveFloatData(positionPlayerDataKey + ".x", x);
        SaveFloatData(positionPlayerDataKey + ".y", y);
    }

    public float[] LoadPositionPlayerData()
    {
        return new float[] { LoadFloatData(positionPlayerDataKey + ".x"), LoadFloatData(positionPlayerDataKey + ".y") };
    }

    public string LoadStringData(string key)
    {
        return PlayerPrefs.GetString(key);
    }

    public int LoadIntData(string key)
    {
        return PlayerPrefs.GetInt(key);
    }

    public float LoadFloatData(string key)
    {
        return PlayerPrefs.GetFloat(key);
    }

    public void SaveStringData(string key, string data)
    {
        PlayerPrefs.SetString(key, data);
    }

    public void SaveIntData(string key, int data)
    {
        PlayerPrefs.SetInt(key, data);
    }

    public void SaveFloatData(string key, float data)
    {
        PlayerPrefs.SetFloat(key, data);
    }
}
