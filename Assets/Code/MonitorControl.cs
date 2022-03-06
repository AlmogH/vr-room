using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MonitorControl : MonoBehaviour
{
    public TextMeshProUGUI Textchange;

    public void arrowDown()
    {
        if(Textchange.text == "2022")
        {
            Textchange.text = "2021";
        }
    }
}
