public class PlayerHierarchicalIdleState : PlayerBaseHierarchicalState
{
    public PlayerHierarchicalIdleState(PlayerHierarchicalStateManager context, PlayerHierarchicalStateFactory factory) : base(context, factory)
    {
    }

    public override void CheckSwitchStates()
    {
        if (Context.HorizontalInput != 0)
        {
            SwitchState(Factory.Walk());
        }
    }

    public override void EnterState()
    {
        Context.Animator.SetBool("isWalking", false);
        Context.SetSecondText("Idle");
    }

    public override void ExitState()
    {
    }

    public override void InitializeSubState()
    {
    }

    public override void UpdateState()
    {
    }
}
