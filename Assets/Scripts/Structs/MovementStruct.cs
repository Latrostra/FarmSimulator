using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MovementStruct
{
    public Vector3 nextDirection;
    public Vector3 nextPosition;
    public MovementStruct(Vector3 nextDirection, Vector3 nextPosition)
    {
        this.nextDirection = nextDirection;
        this.nextPosition = nextPosition;
    }
}
