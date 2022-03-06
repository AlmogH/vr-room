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
        bool check = true;
        if (vars.first != null && !vars.first.Equals(vars.firstAnswer))
            check = false;
        if (vars.second != null && !vars.second.Equals(vars.secondAnswer))
            check = false;
        if (vars.third != null && !vars.third.Equals(vars.thirdAnswer))
            check = false;
        if (check)
            vars.correctEvent.Raise();
        else
            vars.wrongEvent.Raise();
    }

    public void Solve()
    {
        Debug.Log("solveeeeee");
        vars.first = vars.firstAnswer;
        vars.second = vars.secondAnswer;
        vars.third = vars.thirdAnswer;
    }

    private void UpdateVars()
    {
        Debug.Log("Update terminal options");
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
        if (vars.first)
            vars.first.Up();
    }
    public void SecondUp()
    {
        if (vars.second)
            vars.second.Up();
    }
    public void ThirdUp()
    {
        if (vars.third)
            vars.third.Up();
    }

    public void FirstDown()
    {
        if (vars.first)
            vars.first.Down();
    }
    public void SecondDown()
    {
        if (vars.second)
            vars.second.Down();
    }
    public void ThirdDown()
    {
        if (vars.third)
            vars.third.Down();
    }
}
