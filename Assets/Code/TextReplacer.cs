// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextReplacer : MonoBehaviour
{
    public TextMeshProUGUI Text;

    public Object Variable;

    public bool AlwaysUpdate;

    private void OnEnable()
    {
        Text.text = Variable.ToString();
    }

    private void Update()
    {
        if (AlwaysUpdate)
        {
            Text.text = Variable.ToString();
        }
    }
}
