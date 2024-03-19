using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class EntityJumpingState : EntityState
{
    public override void EnterState(Entity entity){
        Animator animator = entity.GetComponent<Animator>();
        entity.rigidbody.velocity = new Vector2(entity.rigidbody.velocity.x, entity.jumpingPower);
        animator.runtimeAnimatorController = entity.MushrioJump as RuntimeAnimatorController;
    }
    public override void UpdateState(Entity entity){

    }
    public override void FixedUpdateState(Entity entity){
        entity.rigidbody.velocity = new Vector2(entity.horizontal * entity.speed, entity.rigidbody.velocity.y);
    }
    public override void OnCollisionEnter(Entity entity)
    {
        entity.currentState = entity.idleState;
        entity.currentState.EnterState(entity);
    }
}
