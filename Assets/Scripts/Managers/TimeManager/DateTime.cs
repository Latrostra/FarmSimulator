using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Time/TimeSO")]
public class DateTime : ScriptableObject
{
    public float Seconds;
    public int Minutes;
    public int Hours;
    public int Day;
    public int Months;
    public int Years;

    public void SetDMR(int day, int month, int year) {
        Day = day;
        Months = month;
        Years = year;
    }

    public bool CompareDates(DateTime dateTime) {
        if (dateTime.Years >= Years) {
            if (dateTime.Months >= Months) {
                
                return true;
            }
        }
        return false;
    }
    public bool CompareDates(int year, int month) {
        if (year >= Years) {
            if (month >= Months) {
                
                return true;
            }
        }
        return false;
    }
}
