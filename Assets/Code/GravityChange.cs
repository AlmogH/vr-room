using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
    public FloatVariable x;
    public FloatVariable y;
    public FloatVariable z;

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Rigidbody rigidBody))
        {
            if (rigidBody.useGravity)
            {
                ContinuousForce cf = other.gameObject.AddComponent<ContinuousForce>() as ContinuousForce;
                Vector3 force = new Vector3(x.Value, y.Value, z.Value);
                rigidBody.useGravity = false;
                cf.on = true;
                cf.force = force;
            }
            else
            {
                if (other.TryGetComponent(out ContinuousForce cf))
                    cf.on = false;
                rigidBody.useGravity = true;
            }
        }
    }
}
