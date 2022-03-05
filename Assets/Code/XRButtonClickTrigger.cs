using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class XRButtonClickTrigger : MonoBehaviour
{
    // [SerializeField] private float threshold = 0.1f;
    // [SerializeField] private float deadZone = 0.025f;


    private float invokeSpeedStart = 1f;
    private bool isPressed;
    // private Vector3 _startPos;
    // private ConfigurableJoint _joint;
    private float invokeSpeed;

    public UnityEngine.Events.UnityEvent onClicked, onReleased, onPress;
    // Start is called before the first frame update
    void Start()
    {
        invokeSpeed = invokeSpeedStart;
        // _startPos = transform.position;
        // _joint = GetComponent<ConfigurableJoint>();
    }

    // private float GetValue()
    // {
    //     var value = Vector3.Distance(_startPos, transform.position) / _joint.linearLimit.limit;

    //     if (Mathf.Abs(value) < deadZone)
    //         value = 0;

    //     Debug.Log(Vector3.Distance(_startPos, transform.position) / _joint.linearLimit.limit);
    //     return Mathf.Clamp(value, -1f, 1f);
    // }

    // Update is called once per frame
    void Update()
    {
        // if (!_isPressed && GetValue() + threshold >= 1)
        //     Clicked();
        // else if (_isPressed && GetValue() - threshold <= 0)
        //     Released();
    }

    // private void OnTriggerStay(Collider other)
    // {
    //     onPress.Invoke();
    // }

    private void OnTriggerExit(Collider other)
    {
        CancelInvoke();
        onReleased.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        // onClicked.Invoke();
        onClicked.Invoke();
        onPress.Invoke();
        InvokeRepeating("Press",0.3f,0.05f);
        // InvokeSpeedChange();
    }

    private void Press()
    {
        onPress.Invoke();
        // Debug.Log("Pressing");
    }

    // private void InvokeSpeedChange()
    // {
    //     CancelInvoke();
    //     InvokeRepeating("Press", 0, invokeSpeed);
    //     if (invokeSpeed > 0.1f)
    //     {
    //         invokeSpeed -= 0.1f;

    //     }
    //     else if (invokeSpeed > 0.01)
    //     {
    //         invokeSpeed -= 0.01f;
    //     }
    //     if (invokeSpeed > 0.5)
    //         Invoke("InvokeSpeedChange", invokeSpeed);
    //     else
    //         Invoke("InvokeSpeedChange", 0.5f);
    // }

    // private void Clicked()
    // {
    //     _isPressed = true;
    //     onClicked.Invoke();
    //     InvokeSpeedChange();
    //     Debug.Log("Pressed");
    // }

    // private void Released()
    // {
    //     CancelInvoke();
    //     invokeSpeed = invokeSpeedStart;
    //     _isPressed = false;
    //     onReleased.Invoke();
    //     Debug.Log("Released");
    // }
}
