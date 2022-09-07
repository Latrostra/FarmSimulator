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
        timeTextHours.SetText("{0:00}:{1:00}", TimeLapse.Instance.dateTime.Hours, TimeLapse.Instance.dateTime.Minutes);
        timeTextData.SetText("{0:00}.{1:00}.{2:0000}", TimeLapse.Instance.dateTime.Day, TimeLapse.Instance.dateTime.Months, TimeLapse.Instance.dateTime.Years);
        timeTextDay.SetText(TimeLapse.Instance.dayOfWeek.ToString());
        timeTextSpeed.SetText("x{}", TimeLapse.Instance.timeSpeed);
    }
}
