using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonMovementController : MonoBehaviour
{
    Vector2 movement = new Vector2(0,0);

    public void ButtonUp()
    {
        movement.y = 1f;
    }

    public void ButtonRight()
    {
        movement.x = 1f;
    }

    public void ButtonDown()
    {
        movement.y = -1f;
    }

    public void ButtonLeft()
    {
        movement.x = -1f;
    }
    
    public void ButtonEventUpDown()
    {
        movement.y = 0f;
    }

    public void ButtonEventRightLeft()
    {
        movement.x = 0f;
    }
    
    public Vector2 GetMovementVector2()
    {
        return movement;
    }
}
