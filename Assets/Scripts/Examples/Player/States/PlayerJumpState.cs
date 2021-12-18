using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerBaseState
{
    public PlayerJumpState(PlayerStateManager context, PlayerStateFactory factory) : base(context, factory)
    {
    }

    public override void EnterState()
    {
        Context.PlayerVelocityY += Mathf.Sqrt(Context.JumpHeight * -3.0f * Context.GravityValue);
        Context.Animator.SetTrigger("Jump");
        Context.SetText("Jumping");
    }

    public override void ExitState()
    {
        Debug.Log("Exiting PlayerJumpState");
    }

    protected override void CheckSwitchState()
    {
        if (Context.IsGrounded)
            Context.SwitchState(Factory.Idle());
        else if (Context.HorizontalInput != 0)
            Context.SwitchState(Factory.Walking());
    }
}
