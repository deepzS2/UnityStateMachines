using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkingState : PlayerBaseState
{
    public PlayerWalkingState(PlayerStateManager context, PlayerStateFactory factory) : base(context, factory)
    {
    }

    public override void EnterState()
    {
        Context.Animator.SetBool("isWalking", true);
        Context.SetText("Walking");
    }

    public override void UpdateState()
    {
        base.UpdateState();

        Vector3 move = new Vector3(Context.HorizontalInput, 0, 0);
        Context.Controller.Move(move * Time.deltaTime * Context.Speed);

        if (move != Vector3.zero)
        {
            Context.gameObject.transform.forward = move;
        }
    }

    public override void ExitState()
    {
        Context.Animator.SetBool("isWalking", false);
        Debug.Log("Exiting PlayerWalkingState");
    }

    protected override void CheckSwitchState()
    {
        if (Context.HorizontalInput == 0)
            Context.SwitchState(Factory.Idle());
        else if (Input.GetButtonDown("Jump"))
            Context.SwitchState(Factory.Jump());
    }
}
