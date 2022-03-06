using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Terminal Variables to set what the buttons effect
/// </summary>
[CreateAssetMenu]
public class TerminalVariables : ScriptableObject
{

    public BaseVariable first;
    public BaseVariable second;
    public BaseVariable third;

    public BaseVariable firstAnswer;
    public BaseVariable secondAnswer;
    public BaseVariable thirdAnswer;

    public GameEvent correctEvent;
    public GameEvent wrongEvent;
}
