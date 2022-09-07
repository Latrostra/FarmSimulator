using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using ScriptableObjectArchitecture;

public class TimerManagerTool : EditorWindow
{
    Object dateTime;
    [MenuItem("Tools/Manage Time")]
    public static void ShowWindow() {
        GetWindow(typeof(TimerManagerTool));
    }

    private void OnGUI() {
        dateTime = EditorGUILayout.ObjectField("DateTime ScriptableObject: ", dateTime, typeof(DateTime), false);

        if (GUILayout.Button("Add Day")) {
            AddDay();
        }
        if (GUILayout.Button("Add Month")) {
            AddMonth();
        }
        if (GUILayout.Button("Add Year")) {
            AddYear();
        }
    }

    private void AddDay() {
        if (dateTime is DateTime time) {
            time.Day += 1;
        }
    }
    private void AddMonth() {
        if (dateTime is DateTime time) {
            time.Months += 1;
        }
    }
    private void AddYear() {
        if (dateTime is DateTime time) {
            time.Years += 1;
        }
    }
}
