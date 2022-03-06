using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TerminalOptionDisplay : MonoBehaviour
{
    public TerminalVariables vars;

    public GameObject firstText;
    public GameObject secondText;
    public GameObject thirdText;


    // Start is called before the first frame update
    void Start()
    {
        UpdateVars();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void UpdateVars()
    {
        TextMeshProUGUI firstTMPro = firstText.GetComponent<TextMeshProUGUI>();
        TextReplacer firstTextReplacer = firstText.GetComponent<TextReplacer>();
        firstTextReplacer.Text = firstTMPro;
        firstTextReplacer.AlwaysUpdate = true;
        firstTextReplacer.Variable = vars.first;

        TextMeshProUGUI secondTMPro = secondText.GetComponent<TextMeshProUGUI>();
        TextReplacer secondTextReplacer = secondText.GetComponent<TextReplacer>();
        secondTextReplacer.Text = secondTMPro;
        secondTextReplacer.AlwaysUpdate = true;
        secondTextReplacer.Variable = vars.second;

        TextMeshProUGUI thirdTMPro = thirdText.GetComponent<TextMeshProUGUI>();
        TextReplacer thirdTextReplacer = thirdText.GetComponent<TextReplacer>();
        thirdTextReplacer.Text = thirdTMPro;
        thirdTextReplacer.AlwaysUpdate = true;
        thirdTextReplacer.Variable = vars.third;
    }

    public void ChangeVars(TerminalVariables newVars)
    {
        if (vars != newVars)
        {
            vars = newVars;
            UpdateVars();
        }
    }

    public void FirstUp()
    {
        vars.first.Up();
    }
    public void SecondUp()
    {
        vars.second.Up();
    }
    public void ThirdUp()
    {
        vars.third.Up();
    }

    public void FirstDown()
    {
        vars.first.Down();
    }
    public void SecondDown()
    {
        vars.second.Down();
    }
    public void ThirdDown()
    {
        vars.third.Down();
    }
}
