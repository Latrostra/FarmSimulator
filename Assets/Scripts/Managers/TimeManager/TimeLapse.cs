using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Helpers;
using ScriptableObjectArchitecture;

namespace Managers {
    //Kiedys to przenieść do ScriptableObject
    public class TimeLapse : Singleton<TimeLapse>
    {
        public Action monthPass;
        [SerializeField]
        public DateTimeVariable dateTime;
        public float thisDayOfWeek;
        public Day dayOfWeek;
        public Month monthsOfYears;
        public float timeSpeed = 1;

        void Start()
        {
            timeSpeed = 1;

            StartDate();
        }

        private void FixedUpdate()
        {
            dateTime.Value.Seconds += Time.fixedDeltaTime * timeSpeed;
        }

        void Update()
        {
            SecondsToMinutes();
            MinutesToYears();
            DayOfWeek();
            MonthsOfYear();
        }

        void SecondsToMinutes()
        {
            if (dateTime.Value.Seconds >= 60 && dateTime.Value.Seconds <= 100)
            {
                dateTime.Value.Minutes++;
                dateTime.Value.Seconds = 0;
            }
            else if (dateTime.Value.Seconds >= 3600)
            {
                dateTime.Value.Minutes =+ 60;
                dateTime.Value.Seconds = 0;
            }
        }  

        void MinutesToYears()
        {
        if (dateTime.Value.Minutes >= 60)
        {
            dateTime.Value.Minutes = 0;
            dateTime.Value.Hours++;

            if (dateTime.Value.Hours >= 24)
            {
                dateTime.Value.Hours = 0;
                dateTime.Value.Day++;
                thisDayOfWeek++;

                if (dateTime.Value.Day >= 31)
                {
                    dateTime.Value.Day = 1;
                    dateTime.Value.Months++;
                    monthPass?.Invoke();

                    if (dateTime.Value.Months >= 13)
                    {
                        dateTime.Value.Months = 1;
                        dateTime.Value.Years++;
                    }
                }
            }
        }
        }

        void DayOfWeek()
        {
            if (thisDayOfWeek == 8) {
                thisDayOfWeek = 1;
            }
            dayOfWeek = (Day)thisDayOfWeek;
        }

        void MonthsOfYear()
        {
            monthsOfYears = (Month)dateTime.Value.Months;
        }

        void StartDate()
        {
            thisDayOfWeek = 1;
        }

        public void SlideSpeed(float speedMultiplier)
        {
            switch(speedMultiplier)
            {
                case 0:
                    timeSpeed = 1;
                        break;
                case 1:
                    timeSpeed = 60;
                    break;
                case 2:
                    timeSpeed = 600;
                    break;
                case 3:
                    timeSpeed = 6000;
                    break;
                case 4:
                    timeSpeed = 60000;
                    break;
                case 5:
                    timeSpeed = 600000;
                    break;
                case 6:
                    timeSpeed = 6000000;
                    break;

            }

        }
    }
}
       
