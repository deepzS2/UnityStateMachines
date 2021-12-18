using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState(PlayerStateManager context, PlayerStateFactory factory) : base(context, factory)
    {
    }

    public override void EnterState()
    {
        Context.SetText("Idle");
    }

    public override void ExitState()
    {
        Debug.Log("Exiting PlayerIdleState");
    }

    protected override void CheckSwitchState()
    {
        if (Input.GetButtonDown("Jump"))
            Context.SwitchState(Factory.Jump());
        else if (Context.HorizontalInput != 0)
            Context.SwitchState(Factory.Walking());
    }
}
