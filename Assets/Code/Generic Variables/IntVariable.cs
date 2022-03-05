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
    public override void Up()
    {
        Value += 1;
    }

    public override void Down()
    {
        Value -= 1;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}