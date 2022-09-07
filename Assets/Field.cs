using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class Field : MonoBehaviour
{
    public virtual void Awake() {
        var tile = GridManager.Instance.gridGO[(int)this.transform.position.x + 500, (int)this.transform.position.y + 500];
        if (tile == null) {
            GridManager.Instance.gridGO[(int)this.transform.position.x + 500, (int)this.transform.position.y + 500] = this.gameObject;
            return;
        }
        Destroy(GridManager.Instance.gridGO[(int)this.transform.position.x + 500, (int)this.transform.position.y + 500]);
        GridManager.Instance.gridGO[(int)this.transform.position.x + 500, (int)this.transform.position.y + 500] = this.gameObject;
    }
}
