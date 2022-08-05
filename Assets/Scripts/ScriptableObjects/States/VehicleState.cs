using System;
using ScriptableObjectArchitecture;
using ScriptableObjects.States;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "VehicleState", menuName = "VehicleState/VehicleState", order = 51)]
public abstract class VehicleState : State
{
    [SerializeField] protected GameObjectVariable vehicle;
    [SerializeField] protected GameObjectVariable player;
    
    protected Rigidbody2D rigidbody2D;
    protected Transform transform;
    protected Animator animator;
    protected Collider2D collider2D;

    [NonSerialized]
    private bool isInitialized;

    private void FirstInitialization()
    {
        rigidbody2D = vehicle.Value.GetComponent<Rigidbody2D>();
        transform = vehicle.Value.transform;
        animator = vehicle.Value.GetComponent<Animator>();
        collider2D = vehicle.Value.GetComponent<Collider2D>();
    }

    public override void _Init()
    {
        if (isInitialized) return;

        FirstInitialization();
        isInitialized = true;
    }

    public override void _Finish()
    {
    }
}
