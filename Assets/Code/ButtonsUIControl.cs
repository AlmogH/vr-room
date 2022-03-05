using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonsUIControl : MonoBehaviour
{
    public TextMeshProUGUI Textchange;

    void Start()
    {
        // Debug.Log("blakjsdlkjfdlklbjkdflkbjk");
    }

    public void OnDialChange(float change){
        Debug.Log(change);
    }

    public void OnDialChange(int change){
        Debug.Log(change);
    }
}
