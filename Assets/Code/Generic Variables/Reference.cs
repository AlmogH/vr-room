using System;
using UnityEngine;

/// <summary>
/// Reference Class.
/// </summary>
[Serializable]
public abstract class Reference
{
}

/// <summary>
/// Reference Class.
/// </summary>
[Serializable]
public class Reference<T, G> : Reference where G : Variable<T>
{
    public bool UseConstant = true;

    public T ConstantValue;

    public G Variable;

    public Reference() { }
    public Reference(T value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    public T Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
        set
        {
            if (UseConstant)
                ConstantValue = value;
            else
                Variable.Value = value;
        }
    }

    public static implicit operator T(Reference<T, G> Reference)
    {
        return Reference.Value;
    }

    public static implicit operator Reference<T, G>(T Value)
    {
        return new Reference<T, G>(Value);
    }

    public override string ToString()
    {
        return Value.ToString();
    }


    public override bool Equals(object obj)
    {

        //Check for null and compare run-time types.
        if ((obj != null))
        {
            if (this.GetType().Equals(obj.GetType()))
                return Value.Equals(((Reference<T, G>)obj).Value);
            else if (Value.GetType().Equals(obj.GetType()))
                return Value.Equals(obj);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}