using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;
using ScriptableObjects.Tiles;

public class SeededField : Field
{
    [SerializeField]
    private DateTime nextStageTime;
    private bool timerIsRunning = true;
    [SerializeField]
    public Tile nextTile;
    
    public void Start() {
        PlantManager.Instance.OnGrow += GrowHandler;
    }
    public void GrowHandler(int years, int months) {
        if (nextStageTime.CompareDates(new DateTime(0, months, years)))
        {
            Debug.Log("dupa");
            nextTile.Create(this.transform.position);
            timerIsRunning = false;
        }
    }

    public void OnDestroy() {
        PlantManager.Instance.OnGrow -= GrowHandler;
    }
}
