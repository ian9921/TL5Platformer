using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class EntityIdleState : EntityState
{
    public override void EnterState(Entity entity){
        Animator animator = entity.GetComponent<Animator>();
        animator.runtimeAnimatorController = entity.MushrioIdle as RuntimeAnimatorController;
    }
    public override void UpdateState(Entity entity){
        if(entity.horizontal != 0){
            entity.currentState = entity.runState;
            entity.currentState.EnterState(entity);
        }
    }
    public override void FixedUpdateState(Entity entity){
        entity.rigidbody.velocity = new Vector2(entity.horizontal * entity.speed, entity.rigidbody.velocity.y);
    }
    public override void OnCollisionEnter(Entity entity)
    {

    }
}
