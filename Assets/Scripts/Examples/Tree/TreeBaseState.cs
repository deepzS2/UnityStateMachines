public abstract class TreeBaseState : State
{
    protected TreeStateManager Context;
    protected TreeStateFactory Factory;

    public TreeBaseState(TreeStateManager context, TreeStateFactory factory)
    {
        Context = context;
        Factory = factory;
    }
}
