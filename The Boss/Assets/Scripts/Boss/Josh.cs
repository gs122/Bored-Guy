using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Josh : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Animator GetAnimator()
    {
        return animator;
    }

    public void Enter()
    {
        Debug.Log("Josh should enter");
        animator.SetTrigger("JoshEnter");
    }

    public void Exit()
    {
        Debug.Log("Josh should exit");
        animator.SetTrigger("JoshExit");
    }
}
