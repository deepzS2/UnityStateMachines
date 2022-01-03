using UnityEngine;

public abstract class PlayerBaseHierarchicalState : HierarchicalState<PlayerHierarchicalStateManager, PlayerBaseHierarchicalState>
{
    protected PlayerHierarchicalStateFactory Factory;

    public PlayerBaseHierarchicalState(PlayerHierarchicalStateManager context, PlayerHierarchicalStateFactory factory) : base(context)
    {
        Factory = factory;
    }
}
