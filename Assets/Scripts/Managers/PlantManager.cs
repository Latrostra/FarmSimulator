using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Helpers;
using System;

namespace Managers {
    public class PlantManager : Singleton<PlantManager>
    {
        public Action<int, int> OnGrow;
        public void Start() {
            TimeLapse.Instance.monthPass += MonthPassHandler;
        }

        public void MonthPassHandler() {
            OnGrow?.Invoke(TimeLapse.Instance.dateTime.Value.Years, TimeLapse.Instance.dateTime.Value.Months);
        }
    }
}

