using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFight : StateMachineBehaviour
{
	Transform player;
	public float speed = 1f;
	Boss boss;
	public float attackRange = 3f;
   
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int indexLayer)
    {
	player = GameObject.FindGameObjectWithTag("Player").transform;
	boss = animator.GetComponent<Boss>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int indexLayer)
    {
    	
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int indexLayer)
    {
    	animator.ResetTrigger("Attack");
    }
}
