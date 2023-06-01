using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMover : MonoBehaviour
{

    Animator animator;
    List<Action> actions;
    List<Tuple<int, Action>> phaseChanges;
    int currDialogueActionIndex;
    int currCombatActionIndex;
    Boss boss;
    int hpUntilNextAction;
    Action nextAction;
    int currPhase;
    bool canChangePhase;
    Player player;

    // Start is called before the first frame update
    void Start()
    {

        player = FindObjectOfType<Player>();
        boss = FindObjectOfType<Boss>();
        animator = GetComponent<Animator>();
        actions = new List<Action>();
        phaseChanges = new List<Tuple<int, Action>>();
        canChangePhase = true;

        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetBool("Phase0CombatComplete", true)));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetTrigger("Phase1IncreaseDifficulty")));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetBool("Phase1CombatComplete", true)));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetTrigger("Phase2IncreaseDifficulty")));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetTrigger("Phase2IncreaseDifficulty1")));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetBool("Phase2CombatComplete", true)));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetTrigger("Phase3IncreaseDifficulty")));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetTrigger("Phase3IncreaseDifficulty1")));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetBool("Phase3CombatComplete", true)));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetBool("Phase4CombatComplete", true)));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetTrigger("Phase5IncreaseDifficulty")));
        phaseChanges.Add(new Tuple<int, Action>(-120, () => animator.SetBool("Phase5CombatComplete", true)));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetBool("Phase6CombatComplete", true)));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetBool("Phase7CombatComplete", true)));
        phaseChanges.Add(new Tuple<int, Action>(-120, () => animator.SetBool("Phase8CombatComplete", true)));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetTrigger("Phase9IncreaseDifficulty")));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetTrigger("Phase9IncreaseDifficulty1")));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetTrigger("Phase9IncreaseDifficulty2")));
        phaseChanges.Add(new Tuple<int, Action>(-30, () => animator.SetTrigger("Phase9IncreaseDifficulty3")));
        phaseChanges.Add(new Tuple<int, Action>(-90 , () => animator.SetBool("Phase9CombatComplete", true)));

        hpUntilNextAction = phaseChanges[0].Item1;
        nextAction = phaseChanges[0].Item2;
        //Debug.Log(hpUntilNextAction);
        //Debug.Log(nextAction.Method.ToString());

        // Iterate through dialogue by an index of 1 every time a dialogue is completed
        // Iterate through combat actions by an index of 1 every time a health threshold is reached


    }

    // Update is called once per frame
    void Update()
    {
        if (canChangePhase == true)
        {
            if (boss.GetHp() < hpUntilNextAction)
            {
                nextAction();
                boss.SetHp(0);
                currPhase++;
                hpUntilNextAction = phaseChanges[currPhase].Item1;
                nextAction = phaseChanges[currPhase].Item2;
            }
            canChangePhase = false;
            Invoke("CanChangePhase", 1f);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Spin"))
        {
            player.SetCanControl(false);
        }

    }

    private void CanChangePhase()
    {
        canChangePhase = true;
    }


    public Animator GetAnimator()
    {
        return animator;
    }

    public void Spin()
    {
        animator.SetTrigger("Spin");
    }

}
