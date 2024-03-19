using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public float horizontal;
    public Rigidbody2D rigidbody;

    [SerializeField]
    public float speed;

    [SerializeField]
    public float jumpingPower;

    public RuntimeAnimatorController MushrioJump;
    public RuntimeAnimatorController MushrioWalkR;
    public RuntimeAnimatorController MushrioIdle;
    public RuntimeAnimatorController MushrioDead;

    public EntityState currentState;
    public EntityIdleState idleState = new EntityIdleState();
    public EntityRunState runState = new EntityRunState();
    public EntityJumpingState jumpingState = new EntityJumpingState();
    public EntityDeadState deadState = new EntityDeadState();
    void Start()
    {
        currentState = idleState;
        currentState.EnterState(this);
    }

}
