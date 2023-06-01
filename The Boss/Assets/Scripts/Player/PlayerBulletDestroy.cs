using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletDestroy : StateMachineBehaviour
{

    SpriteRenderer spriteRenderer;
    float opacity;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        opacity = 1f;
        spriteRenderer = animator.gameObject.GetComponent<SpriteRenderer>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Destroy(animator.gameObject);
    }
}
