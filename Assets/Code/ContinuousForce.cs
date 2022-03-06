using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Set a continuous force to mimic gravity
/// </summary>
public class ContinuousForce : MonoBehaviour
{

    public Vector3 force;
    public bool on;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject.TryGetComponent(out Rigidbody rigidBody))
        {
            if (on)
            {
                rigidBody.AddForce(force);
            }
        }
    }
}
