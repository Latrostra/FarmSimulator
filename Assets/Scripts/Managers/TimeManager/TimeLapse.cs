using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Helpers;

namespace Managers {
    //Kiedys to przenieść do ScriptableObject
    public class TimeLapse : Singleton<TimeLapse>
    {
        public Action monthPass;
        public DateTime dateTime;
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
            dateTime.Seconds += Time.fixedDeltaTime * timeSpeed;
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
            if (dateTime.Seconds >= 60 && dateTime.Seconds <= 100)
            {
                dateTime.Minutes++;
                dateTime.Seconds = 0;
            }
            else if (dateTime.Seconds >= 3600)
            {
                dateTime.Minutes =+ 60;
                dateTime.Seconds = 0;
            }
        }  

        void MinutesToYears()
        {
        if (dateTime.Minutes >= 60)
        {
            dateTime.Minutes = 0;
            dateTime.Hours++;

            if (dateTime.Hours >= 24)
            {
                dateTime.Hours = 0;
                dateTime.Day++;
                thisDayOfWeek++;

                if (dateTime.Day >= 31)
                {
                    dateTime.Day = 1;
                    dateTime.Months++;
                    monthPass?.Invoke();

                    if (dateTime.Months >= 13)
                    {
                        dateTime.Months = 1;
                        dateTime.Years++;
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
            monthsOfYears = (Month)dateTime.Months;
        }

        void StartDate()
        {
            dateTime = new DateTime(2022, 3, 12, 10, 2, 0);

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
       
