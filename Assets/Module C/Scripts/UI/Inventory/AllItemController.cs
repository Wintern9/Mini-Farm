using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllItemController : MonoBehaviour
{
    /// <summary>
    /// ���� ���������� ��� ������� ��������� (��� ������ ���������)
    /// </summary>
    [SerializeField] private List<Sprite> AllItemSpriteList = new List<Sprite>();
    /// <summary>
    /// ������ ���������� id ��������� ������� ����� ������������ ��� ����������
    /// </summary>
    static public int[] idTools = new int[] {1, 2};

    public List<Sprite> GetList()
    {
        return AllItemSpriteList;
    }
}
