using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTravel : MonoBehaviour
{

    public ListStringVariable places;
    public StringVariable correctPlace;
    public IntVariable year;
    public IntReference correctYear;

    public UnityEngine.Events.UnityEvent onClick;

    public void Launch()
    {
        if (places.Value.Equals(correctPlace) && year.Value.Equals(correctYear.Value))
        {
            onClick.Invoke();
        }
    }
}
