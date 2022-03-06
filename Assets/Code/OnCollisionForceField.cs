using System;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionForceField : MonoBehaviour
{

    public bool canCollide = false;
    public GameEvent FinishScene;

    private void OnCollisionEnter(Collision collision)
    {
        if (canCollide)
        {
            Destroy(this.gameObject);
            Invoke("Finish", 5);
        }
    }

    private void Finish()
    {
        FinishScene.Raise();
    }

    public void SetCanCollide(bool col)
    {
        canCollide = col;
    }

}
