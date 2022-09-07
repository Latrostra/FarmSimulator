using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Helpers;
using System;

namespace Managers {
    public class PlantManager : Singleton<PlantManager>
    {
        public Action<int, int> OnGrow;
        private int Months = 0;

        public void Start() {
            TimeLapse.Instance.monthPass += MonthPassHandler;
        }

        public void MonthPassHandler() {
            OnGrow?.Invoke(TimeLapse.Instance.dateTime.Years, TimeLapse.Instance.dateTime.Months);
        }
    }
}

