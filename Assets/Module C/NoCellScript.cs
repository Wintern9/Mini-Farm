using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCellScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NoCell"))
        {
            FieldCellController.EnebledCell = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NoCell"))
        {
            FieldCellController.EnebledCell = false;
        }
    }
}
