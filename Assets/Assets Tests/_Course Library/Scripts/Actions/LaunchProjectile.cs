using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// Apply forward force to instantiated prefab
/// </summary>
public class LaunchProjectile : MonoBehaviour
{
    [Tooltip("The projectile that's created")]
    public GameObject projectilePrefab = null;

    [Tooltip("The point that the project is created")]
    public Transform startPoint = null;

    [Tooltip("The speed at which the projectile is launched")]
    public IntVariable launchSpeed;

    public ListStringVariable bulletSize;

    public StringVariable bulletLarge;
    public StringVariable bulletMedium;

    public void Fire()
    {
        GameObject newObject = Instantiate(projectilePrefab, startPoint.position, startPoint.rotation);



        if (newObject.TryGetComponent(out Rigidbody rigidBody))
        {
            if (bulletSize.Value == bulletLarge.Value)
            {
                newObject.transform.localScale = new Vector3(3, 3, 3);
                rigidBody.mass = 3;
            }
            else if (bulletSize.Value == bulletMedium.Value)
            {
                newObject.transform.localScale = new Vector3(2, 2, 2);
                rigidBody.mass = 2;
            }
            else
            {
                newObject.transform.localScale = new Vector3(1, 1, 1);
                rigidBody.mass = 1;
            }
            ApplyForce(rigidBody);
        }
    }

    private void ApplyForce(Rigidbody rigidBody)
    {
        Vector3 force = startPoint.forward * launchSpeed.Value;
        rigidBody.AddForce(force, ForceMode.Impulse);
    }
}
