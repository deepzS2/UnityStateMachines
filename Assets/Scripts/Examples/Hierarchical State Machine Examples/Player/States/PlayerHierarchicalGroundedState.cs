using UnityEngine;

public class PlayerHierarchicalGroundedState : PlayerBaseHierarchicalState
{
    public PlayerHierarchicalGroundedState(PlayerHierarchicalStateManager context, PlayerHierarchicalStateFactory factory) : base(context, factory)
    {
        IsRootState = true;
        InitializeSubState();
    }

    public override void CheckSwitchStates()
    {
        if (Input.GetButton("Jump"))
        {
            SwitchState(Factory.Jump());
        }
    }

    public override void EnterState()
    {
        Context.Animator.SetBool("isGrounded", true);
        Context.SetFirstText("Grounded");
        Context.PlayerVelocityY = -0.01f;
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
    }
}
