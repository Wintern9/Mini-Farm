using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] private Text Level;
    [SerializeField] private Text Exp;
    void Update()
    {
        Level.text = "�������: "+ InputData.Level.ToString();
        Exp.text = $"����: {InputData.Exp}/{150 * InputData.Level}";
    }
}
