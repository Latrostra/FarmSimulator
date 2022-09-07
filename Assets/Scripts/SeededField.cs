using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;
using ScriptableObjects.Tiles;

public class SeededField : Field
{
    [SerializeField]
    private DateTime nextStageTime;
    [SerializeField]
    public Tile nextTile;
    
    public void Start() {
        PlantManager.Instance.OnGrow += GrowHandler;
        nextStageTime.Years = TimeLapse.Instance.dateTime.Value.Years + nextStageTime.Years;
    }
    public void GrowHandler(int years, int months) {
        if (nextStageTime.CompareDates(years, months))
        {
            nextTile.Create(this.transform.position);
        }
    }

    public void OnDestroy() {
        PlantManager.Instance.OnGrow -= GrowHandler;
    }
}
