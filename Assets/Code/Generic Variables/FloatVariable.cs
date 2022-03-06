using System;
using UnityEngine;

/// <summary>
/// FloatReference Class.
/// </summary>
[Serializable]
public class FloatReference : Reference<float, FloatVariable>
{
    public FloatReference(float Value) : base(Value)
    {
    }

    public FloatReference()
    {
    }
}

/// <summary>
/// FloatVariable Class.
/// </summary>
[CreateAssetMenu]
public class FloatVariable : Variable<float>
{
    public override void Up()
    {
        Value += 0.1f;
        Value = (float)Math.Round(Value, 2);
    }

    public override void Down()
    {
        Value -= 0.1f;
        Value = (float)Math.Round(Value, 2);
    }

    public override string ToString()
    {
        return Value.ToString("0.0");
    }
}