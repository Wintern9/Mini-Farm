using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllItemController : MonoBehaviour
{
    /// <summary>
    /// Лист содержащий все спрайты предметов (Для работы инвентаря)
    /// </summary>
    [SerializeField] private List<Sprite> AllItemSpriteList = new List<Sprite>();
    /// <summary>
    /// Массив содержащий id предметов которые можно использовать как инструмент
    /// </summary>
    static public int[] idTools = new int[] {1, 2};

    public List<Sprite> GetList()
    {
        return AllItemSpriteList;
    }
}
