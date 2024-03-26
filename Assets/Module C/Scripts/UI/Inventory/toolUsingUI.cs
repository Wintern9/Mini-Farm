using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolUsingUI : MonoBehaviour
{
    [SerializeField] Image image;
    static public Sprite spriteTool;
    static public int idTool;

    static public bool idToolsContains;

    private void Start()
    {
        image.enabled = false;
    }

    private void Update()
    {
        if(idToolsContains)
        {
            image.enabled = true;       
        }
    }

    public void SetSpriteInImage()
    {
        if (spriteTool != null)
        {
            SetToolUsing();
            image.sprite = spriteTool;
        }
    }

    private void SetToolUsing()
    {
        if(idTool == 0)
        {
            ToolsUsing.idTool = 0;
        }
        if(idTool == 1 )
        {
            ToolsUsing.idTool = 1;
        }
        if (idTool == 2)
        {
            ToolsUsing.idTool = 2;
        }
    }
}
