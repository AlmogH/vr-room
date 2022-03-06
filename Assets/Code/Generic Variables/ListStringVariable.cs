using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ListStringVariable Class.
/// </summary>
[CreateAssetMenu]
public class ListStringVariable : Variable<StringVariable>
{
    public List<StringVariable> vars;

    private int index;


    void OnEnable()
    {
        index = vars.IndexOf(Value);
        if (index == -1)
        {
            // throw new KeyNotFoundException();
            Debug.LogError("Key not found" + index + " For Value:" + Value + " in " + vars);
        }
    }

    public override void Up()
    {
        if (index + 1 >= vars.Count)
            index = vars.Count - 2;
        Value = vars[++index];
    }

    public override void Down()
    {
        if (index - 1 <= 0)
            index = 1;
        Value = vars[--index];
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}