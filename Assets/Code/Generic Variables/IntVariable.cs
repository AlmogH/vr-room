using System;
using UnityEngine;

/// <summary>
/// IntReference Class.
/// </summary>
[Serializable]
public class IntReference : Reference<int, IntVariable>
{
    public IntReference(int Value) : base(Value)
    {
    }

    public IntReference()
    {
    }
}

/// <summary>
/// IntVariable Class.
/// </summary>
[CreateAssetMenu]
public class IntVariable : Variable<int>
{

    [SerializeField]
    private int max, min;


    public override void Up()
    {
        if (Value + 1 <= max)
            Value += 1;
    }

    public override void Down()
    {
        if (Value - 1 >= min)
            Value -= 1;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}