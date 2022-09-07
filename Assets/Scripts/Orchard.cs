using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class Orchard : Field {
    public GameObject gameObject;

    private void Start() {
        Instantiate(gameObject, GridManager.Instance.GetCellCenterPosition(GridManager.Instance.GetWorldPosition(this.transform.position)), Quaternion.identity);
    }
}

