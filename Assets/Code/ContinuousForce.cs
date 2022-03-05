using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousForce : MonoBehaviour
{

    public Vector3 force;
    public bool on;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
