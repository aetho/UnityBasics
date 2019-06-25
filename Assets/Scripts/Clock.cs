using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour {
    const float degPerHour = 30f, degPerMin = 6f, degPerSec = 6f;
    public Transform hoursTransform, MinutesTransform, secondsTransform;
    public bool continuous;
    void UpdateContinuous() {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degPerHour, 0f);
        MinutesTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * degPerMin, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * degPerSec, 0f);
    }
    void UpdateDiscrete() {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f, time.Hour * degPerHour, 0f);
        MinutesTransform.localRotation = Quaternion.Euler(0f, time.Minute * degPerMin, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, time.Second * degPerSec, 0f);
    }

    void Update() {
        if (continuous) {
            UpdateContinuous();
        } else {
            UpdateDiscrete();
        }
    }
}
