using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCellController : MonoBehaviour
{
    private Sprite spriteItem;
    private int spriteItemNum;
    private int idItem;

    [SerializeField]private Image imageItem;

    void Update()
    {
        if (spriteItem != null)
        {
            imageItem.enabled = true;
            imageItem.sprite = spriteItem;
        } else
        {
            imageItem.enabled = false;
        }
        NumTextChange();
    }

    public void SetImage(Sprite sprite, int num, int id)
    {
        spriteItem = sprite;
        spriteItemNum = num;
        idItem = id;
    }

    /// <summary>
    /// Метод для надевания предмета на персонажа
    /// </summary>
    public void PutOnPlayer()
    {
        if (AllItemController.idTools.Contains(idItem))
        {
            ToolUsingUI.idToolsContains = true;
            ToolUsingUI.spriteTool = spriteItem;
            ToolUsingUI.idTool = idItem;
        } else
        {
            ToolUsingUI.idToolsContains = false;
            ToolUsingUI.spriteTool = null;
            ToolUsingUI.idTool = 0;
        }
    }

    void NumTextChange()
    {
        GetComponentInChildren<Text>().text = spriteItemNum.ToString();
    }
}

