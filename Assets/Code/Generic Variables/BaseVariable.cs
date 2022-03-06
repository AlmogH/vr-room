using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base object for all variables
/// </summary>
public abstract class BaseVariable : ScriptableObject
{

    public abstract void Up();
    public abstract void Down();

}
