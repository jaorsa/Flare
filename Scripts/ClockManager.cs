using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ClockManager : MonoBehaviour
{

    public Transform hours, minutes;
    private const float
            hoursToDegrees = 360f / 12f,
            minutesToDegrees = 360f/60f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees);
        minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees);
    }
}
