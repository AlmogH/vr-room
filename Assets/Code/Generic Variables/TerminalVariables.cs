using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
