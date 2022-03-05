using UnityEngine;

/// <summary>
/// Variable Class.
/// </summary>
public abstract class Variable<T> : BaseVariable
{
    public T Value;

    public void SetValue(T value)
    {
        Value = value;
    }

    public void SetValue(Variable<T> value)
    {
        Value = value.Value;
    }
}