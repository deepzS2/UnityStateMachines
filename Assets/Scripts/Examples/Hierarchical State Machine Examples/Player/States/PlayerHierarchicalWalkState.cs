using UnityEngine;

public class PlayerHierarchicalWalkState : PlayerBaseHierarchicalState
{
    public PlayerHierarchicalWalkState(PlayerHierarchicalStateManager context, PlayerHierarchicalStateFactory factory) : base(context, factory)
    {
    }

    public override void CheckSwitchStates()
    {
        if (Context.HorizontalInput == 0)
        {
            SwitchState(Factory.Idle());
        }
    }

    public override void EnterState()
    {
        Context.Animator.SetBool("isWalking", true);
        Context.SetSecondText("Walking");
    }

    public override void ExitState()
    {
    }

    public override void InitializeSubState()
    {
    }

    public override void UpdateState()
    {
        Vector3 move = new Vector3(Context.HorizontalInput, 0, 0);
        Context.Controller.Move(move * Time.deltaTime * Context.Speed);

        if (move != Vector3.zero)
        {
            Context.gameObject.transform.forward = move;
        }
    }
}
