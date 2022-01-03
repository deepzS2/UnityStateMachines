using UnityEngine;

public class PlayerHierarchicalJumpState : PlayerBaseHierarchicalState
{
    public PlayerHierarchicalJumpState(PlayerHierarchicalStateManager context, PlayerHierarchicalStateFactory factory) : base(context, factory)
    {
        IsRootState = true;
        InitializeSubState();
    }

    public override void CheckSwitchStates()
    {
        if (Context.IsGrounded)
        {
            SwitchState(Factory.Grounded());
        }
    }

    public override void EnterState()
    {
        Context.PlayerVelocityY += Mathf.Sqrt(Context.JumpHeight * -3.0f * Context.GravityValue);
        Context.SetFirstText("Jump");
        Context.Animator.SetTrigger("Jump");
        Context.Animator.SetBool("isGrounded", false);
    }

    public override void ExitState()
    {
    }

    public override void InitializeSubState()
    {
        if (Context.HorizontalInput == 0)
        {
            SetSubState(Factory.Idle());
        }
        else
        {
            SetSubState(Factory.Walk());
        }
    }

    public override void UpdateState()
    {
        Context.PlayerVelocityY += Context.GravityValue * Time.deltaTime;
    }
}
