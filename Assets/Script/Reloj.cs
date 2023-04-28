using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Reloj : MonoBehaviour
{
    public Transform hoursHand;
    public Transform minutesHand;
    public Transform secondsHand;

    private const float degreesPerHour = 30f;
    private const float degreesPerMinute = 6f;
    private const float degreesPerSecond = 6f;

    void Update()
    {
        // Obtener la hora actual
        System.DateTime time = System.DateTime.Now;

        // Calcular el ángulo de cada manecilla basado en la hora, el minuto y el segundo actuales
        float hoursAngle = time.Hour * degreesPerHour;
        float minutesAngle = time.Minute * degreesPerMinute;
        float secondsAngle = time.Second * degreesPerSecond;

        // Rotar las manecillas a los ángulos correspondientes
        hoursHand.localRotation = Quaternion.Euler(hoursAngle, 0f, 0f);
        minutesHand.localRotation = Quaternion.Euler(minutesAngle, 0f, 0f);
        secondsHand.localRotation = Quaternion.Euler(secondsAngle, 0f, 0f);
    }
}