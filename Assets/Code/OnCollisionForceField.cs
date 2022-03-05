using System;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionForceField : MonoBehaviour
{
    // [Serializable] public class CollisionEvent : UnityEvent<Collision> { }

    // // When the object enters a collision
    // public CollisionEvent OnEnter = new CollisionEvent();

    // // When the object exits a collision
    // public CollisionEvent OnExit = new CollisionEvent();

    // public FloatVariable x;
    // public FloatVariable y;
    // public FloatVariable z;

    private void OnCollisionEnter(Collision collision)
    {
        // if (Physics.gravity.Equals(new Vector3(x.Value,y.Value,z.Value)) && collision.gameObject.TryGetComponent(out Rigidbody rigidBody))
        // {
        //     Destroy(this);
        // }
        // OnEnter.Invoke(collision);
    }

    private void OnCollisionExit(Collision collision)
    {
        // OnExit.Invoke(collision);
    }

    // private void OnValidate()
    // {
    //     if (TryGetComponent(out Collider collider))
    //         collider.isTrigger = false;
    // }
}
