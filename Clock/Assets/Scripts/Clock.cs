using System;
using UnityEngine;


public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    /*[SerializeField]
    Transform minutesPivot;

    [SerializeField]
    Transform secondsPivot;*/

    void Awake() 
    {

        Debug.Log(DateTime.now);
        hoursPivot.localRotation = Quaternion.Euler(0,0,-30);
    }
    
}