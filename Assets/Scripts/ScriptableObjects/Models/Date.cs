using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;

namespace ScriptableObjects.Models
{
    public class Date : ScriptableObject
    {
        private List<Month> months;
        private List<Day> days;
        public MonthVariable CurrentMonth;
        public DayVariable CurrentDay;
        public IntVariable CurrentDayNumber;
        public IntVariable CurrentYear;
        
        public void GoToNextDay()
        {
            
        }
    }
}
