using System;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionForceField : MonoBehaviour
{
    [Serializable] public class CollisionEvent : UnityEvent<Collision> { }

    // When the object enters a collision
    public CollisionEvent OnEnter = new CollisionEvent();

    // When the object exits a collision
    public CollisionEvent OnExit = new CollisionEvent();

    public FloatVariable x;
    public FloatVariable y;
    public FloatVariable z;

    public IntVariable bulletSpeed;
    public ListStringVariable bulletSize;
    public StringVariable bulletSoultion;

    private void Update()
    {
        if (Vector3.Distance(new Vector3(x.Value, y.Value, z.Value), Physics.gravity) < 0.1)
        {
            GetComponent<SphereCollider>().isTrigger = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("speed" + bulletSpeed + bulletSpeed.Equals(27));
        Debug.Log("size" + bulletSize + bulletSize.Equals(bulletSoultion));
        if (bulletSpeed.Equals(27) && bulletSize.Equals(bulletSoultion))
        {
            Destroy(this.gameObject);
        }
        OnEnter.Invoke(collision);
    }

    private void OnCollisionExit(Collision collision)
    {
        OnExit.Invoke(collision);
    }

    // private void OnValidate()
    // {
    //     if (TryGetComponent(out Collider collider))
    //         collider.isTrigger = false;
    // }
}
