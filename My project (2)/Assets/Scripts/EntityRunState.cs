using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class EntityRunState : EntityState
{
    public override void EnterState(Entity entity){
        Animator animator = entity.GetComponent<Animator>();
        animator.runtimeAnimatorController = entity.MushrioWalkR as RuntimeAnimatorController;
    }
    public override void UpdateState(Entity entity){
        Animator animator = entity.GetComponent<Animator>();
        if (entity.horizontal == 0){
            entity.currentState = entity.idleState;
            entity.currentState.EnterState(entity);
            animator.runtimeAnimatorController = entity.MushrioWalkR as RuntimeAnimatorController;
        }
    }
    public override void FixedUpdateState(Entity entity){
        entity.rigidbody.velocity = new Vector2(entity.horizontal * entity.speed, entity.rigidbody.velocity.y);
    }
    public override void OnCollisionEnter(Entity entity)
    {
        
    }
}