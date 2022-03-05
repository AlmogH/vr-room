using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
    public Vector3 gravityForceStart;
    public FloatVariable x;
    public FloatVariable y;
    public FloatVariable z;
    // public GravityVariable gravityForce;

    void Start()
    {
        x.SetValue(gravityForceStart.x);
        y.SetValue(gravityForceStart.y);
        z.SetValue(gravityForceStart.z);
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Rigidbody rigidBody))
        {
            if (rigidBody.useGravity)
            {
                Vector3 force = new Vector3(x.Value, y.Value, z.Value);
                rigidBody.useGravity = false;
                rigidBody.AddForce(force, ForceMode.Impulse);
                rigidBody.AddForce(force);
            }
            else
            {
                rigidBody.useGravity = true;
            }
        }
    }
}
