using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    const float hoursToDegree = -30f, minutesToDegree = -6f, secondsToDegree = -6f;
    
    [SerializeField]
    Transform hoursPivot = default, minutesPivot = default, secondsPivot = default;

    void Update () 
    {
        //Debug.Log(DateTime.Now.Hour);
        //uploading
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f , 0f, hoursToDegree * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f , 0f, minutesToDegree * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f , 0f, secondsToDegree * (float)time.TotalSeconds);
    }
}
