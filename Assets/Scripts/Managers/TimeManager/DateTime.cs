using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class DateTime
{
    [HideInInspector]
    public float Seconds;
    [HideInInspector]
    public int Minutes;
    [HideInInspector]
    public int Hours;
    public int Day;
    public int Months;
    public int Years;

    public DateTime(int years, int months, int day, int hours, int minutes, int seconds)
    {
        Seconds = seconds;
        Minutes = minutes;
        Hours = hours;
        Day = day;
        Months = months;
        Years = years;
    }

    public DateTime(int day, int months, int years) {
        Day = day;
        Months = months;
        Years = years;
    }

    public bool CompareDates(DateTime dateTime) {
        if (dateTime.Years >= Years) {
            if (dateTime.Months >= Months) {
                
                return true;
            }
        }
        return false;
    }
}
