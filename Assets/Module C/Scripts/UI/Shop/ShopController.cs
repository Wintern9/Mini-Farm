using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.Member;
using static UnityEngine.GraphicsBuffer;

public class ShopController : MonoBehaviour
{
    static public ShopItemList[] shopItemListTools;
    static public ShopItemList[] shopItemListSeeds;

    List<ShopItemList> SorterList = new List<ShopItemList>();

    [SerializeField] private GameObject buttonShop;
    [SerializeField] private GameObject ScrollViewContent;

    void Start()
    {
        shopItemListTools = new ShopItemList[] { new ShopItemList() { NameItem = "Лопата", levelItem = 1, IdItem = 1, NumItem = 100, PriceItem = 100}, new ShopItemList() { NameItem = "Мотыга", levelItem = 2, IdItem = 2, NumItem = 100, PriceItem = 200} };
        shopItemListSeeds = new ShopItemList[] { new ShopItemList() { NameItem = "Семена морковки", levelItem = 1, IdItem = 3, NumItem = 1, PriceItem = 20}};

        ShopButtonInstantiate();
    }

   List<GameObject> instantiateButtons;
    private void ShopButtonInstantiate()
    {
        SorterButton();
        if (instantiateButtons != null)
        {
            foreach (var instBut in instantiateButtons)
            {
                Destroy(instBut);
            }
        }
        instantiateButtons = new List<GameObject>();
        float yPosition = 0;
        for (int i = 0; i < SorterList.Count; i++) {
            GameObject button = Instantiate(buttonShop, ScrollViewContent.transform);
            Vector3 positionButton = button.transform.position;
            positionButton.y -= yPosition;
            button.transform.position = positionButton;
            Text[] texts = button.GetComponentsInChildren<Text>();
            texts[0].text = SorterList[i].NameItem + $" (Level {SorterList[i].levelItem})";
            texts[1].text = SorterList[i].PriceItem.ToString();
            instantiateButtons.Add(button);

            button.GetComponent<BuyItemScript>().Price = SorterList[i].PriceItem;
            button.GetComponent<BuyItemScript>().idItem = SorterList[i].IdItem;
            button.GetComponent<BuyItemScript>().NumItem = SorterList[i].NumItem;
            yPosition += 2f;
        }
    }

    private void SorterButton()
    {
        SorterList = new List<ShopItemList>();
        foreach (var element in shopItemListTools)
        {
            if (Array.Exists(LevelsSortInt, x => x == element.levelItem))
            {
                SorterList.Add(element);
            }
        }
    }

    int[] LevelsSortInt = new int[] {1, 2, 3 ,4 ,5};

    public void SortLevel1() {
        if (LevelsSortInt[0] == 1) LevelsSortInt[0] = 0; else LevelsSortInt[0] = 1;
        ShopButtonInstantiate();
    }
    public void SortLevel2()
    {
        if (LevelsSortInt[1] == 2) LevelsSortInt[1] = 0; else LevelsSortInt[1] = 2;
        ShopButtonInstantiate();
    }
    public void SortLevel3()
    {
        if (LevelsSortInt[2] == 3) LevelsSortInt[2] = 0; else LevelsSortInt[2] = 3;
        ShopButtonInstantiate();
    }
    public void SortLevel4()
    {
        if (LevelsSortInt[3] == 4) LevelsSortInt[3] = 0; else LevelsSortInt[3] = 4;
        ShopButtonInstantiate();
    }
    public void SortLevel5()
    {
        if (LevelsSortInt[4] == 5) LevelsSortInt[4] = 0; else LevelsSortInt[4] = 5;
        ShopButtonInstantiate();
    }
}
