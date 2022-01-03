using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGrowedState : TreeBaseState
{
    public TreeGrowedState(TreeStateManager context, TreeStateFactory factory) : base(context, factory)
    {
    }

    public override void EnterState()
    {
        Context.SetText("Growed");
    }

    protected override void CheckSwitchState()
    {
        if (Context.ChopTree)
            Context.SwitchState(Factory.Chopped());
    }
}
