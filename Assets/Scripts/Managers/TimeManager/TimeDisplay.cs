using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using Managers;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI timeTextHours;
    public TextMeshProUGUI timeTextData;
    public TextMeshProUGUI timeTextDay;
    public TextMeshProUGUI timeTextSpeed;

    // Update is called once per frame
    void Update()
    {
        timeTextHours.SetText("{0:00}:{1:00}", TimeLapse.Instance.dateTime.Value.Hours, TimeLapse.Instance.dateTime.Value.Minutes);
        timeTextData.SetText("{0:00}.{1:00}.{2:0000}", TimeLapse.Instance.dateTime.Value.Day, TimeLapse.Instance.dateTime.Value.Months, TimeLapse.Instance.dateTime.Value.Years);
        timeTextDay.SetText(TimeLapse.Instance.dayOfWeek.ToString());
        timeTextSpeed.SetText("x{}", TimeLapse.Instance.timeSpeed);
    }
}
