using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class XRButtonClickTrigger : MonoBehaviour
{


    private float invokeSpeedStart = 1f;
    private bool isPressed;

    public bool isOn = true;

    private float invokeSpeed;

    public UnityEngine.Events.UnityEvent onClicked, onReleased, onPress;
    // Start is called before the first frame update
    void Start()
    {
        invokeSpeed = invokeSpeedStart;
    }

    private void OnTriggerExit(Collider other)
    {
        if (isOn)
        {
            CancelInvoke();
            onReleased.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isOn)
        {
            onClicked.Invoke();
            onPress.Invoke();
            InvokeRepeating("Press", 0.3f, 0.05f);
        }
    }

    private void Press()
    {
        if (isOn)
            onPress.Invoke();
    }

    public void setOn(bool newOn)
    {
        isOn = newOn;
    }
}
