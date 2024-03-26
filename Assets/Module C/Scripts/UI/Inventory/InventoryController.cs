using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] private AllItemController allItemController;

    List<InventoryCell> spritesItemHave;
    List<Sprite> allSpriteObject;

    InventoryCellController[] spritesCellController;

    private void Start()
    {
        spritesCellController = GetComponentsInChildren<InventoryCellController>();
        allSpriteObject = allItemController.GetList();
    }

    private void Update()
    {
        if (spritesItemHave != null)
        {
            for (int i = 0; i < spritesItemHave.Count; i++)
            {
                spritesCellController[i].SetImage(allSpriteObject[spritesItemHave[i].idObject], spritesItemHave[i].numItem, spritesItemHave[i].idObject);
            }
        }
    }

    public void SetSpritesItem(List<InventoryCell> inventoryCells)
    {
        spritesItemHave = inventoryCells;
    }
}
