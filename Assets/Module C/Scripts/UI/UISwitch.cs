using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISwitch : MonoBehaviour
{
    [SerializeField] private GameObject thisUICanvas;
    [SerializeField] private GameObject otherUICanvas;

    bool SwitchBool = true;
    
    public void SwitchUIbool()
    {
        if (SwitchBool)
        {
            thisUICanvas.SetActive(false);
            otherUICanvas.SetActive(true);
            SwitchBool = false;
        }
        else
        {
            thisUICanvas.SetActive(true);
            otherUICanvas.SetActive(false);
            SwitchBool = true;
        }
    }

    public void SwitchUI()
    {

        thisUICanvas.SetActive(false);
        otherUICanvas.SetActive(true);
        SwitchBool = false;

    }
}
