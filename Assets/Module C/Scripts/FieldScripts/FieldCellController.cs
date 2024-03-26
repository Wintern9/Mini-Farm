using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FieldCellController : MonoBehaviour
{
    static public FieledCellInfo[] fieledCellInfo;

    [SerializeField]private GameObject player;
    static public SpriteRenderer[] listCell;
    
    [SerializeField] private GameObject CellBed;

    /// <summary>
    /// Стоит ли игрок в зоне магазина или в зоне доски объявлений
    /// </summary>
    static public bool EnebledCell = false;

    void Start()
    {
        listCell = GetComponentsInChildren<SpriteRenderer>();
        SetFieledCellInfo(listCell);
    }

    void Update()
    {
        if ((ToolsUsing.idTool == 1) && !EnebledCell)
        {
            CellBed.SetActive(true);
            SetCellBed();
        }
        else
        {
            CellBed.SetActive(false);
        }
    }

    private void SetFieledCellInfo(SpriteRenderer[] listCell)
    {
        fieledCellInfo = new FieledCellInfo[listCell.Length];
        for (int i = 0; i < fieledCellInfo.Length; i++)
        {
            fieledCellInfo[i] = new FieledCellInfo() { idCell = i, cellPosition = listCell[i].gameObject.transform.localPosition};
        }
    }

    /// <summary>
    /// Следование грядки за персонажем
    /// </summary>
    private void SetCellBed()
    {
        Vector3 pos = GetPositionPlayerRegardingTargetCell();
        Vector3 positionPlayerOnCell = FieldCellController.fieledCellInfo.OrderBy(o => Vector3.Distance(pos, o.cellPosition)).First().cellPosition;
        CellBed.transform.position = positionPlayerOnCell - new Vector3 (MathF.Abs(gameObject.transform.position.x), -MathF.Abs(gameObject.transform.position.y), 0);
    }

    /// <summary>
    /// Получение позиции игрока относительно точки поля
    /// </summary>
    private Vector3 GetPositionPlayerRegardingTargetCell()
    {
        Vector3 playerPosition = (player.transform.position - gameObject.transform.position);
        playerPosition.y -= 0.6f;
        return playerPosition;
    }
}
