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


    public override bool Equals(object obj)
    {
        //Check for null and compare run-time types.
        if ((obj != null))
        {
            if (this.GetType().Equals(obj.GetType()))
                return Value.Equals(((Variable<T>)obj).Value);
            else if (Value.GetType().Equals(obj.GetType()))
                return Value.Equals(obj);
        }
        return false;
    }


    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}