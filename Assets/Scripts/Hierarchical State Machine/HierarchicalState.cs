/// <summary>
/// Hierarchical State
/// </summary>
/// <typeparam name="T">Typeof hierarchical state manager</typeparam>
/// <typeparam name="U">Typeof the base state</typeparam>
public abstract class HierarchicalState<T, U> where T : HierarchicalStateManager<U> where U : HierarchicalState<T, U>
{
    // The context is the type T
    protected T Context;
    protected HierarchicalState<T, U> CurrentSubState;
    protected HierarchicalState<T, U> CurrentSuperState;
    protected bool IsRootState;

    public HierarchicalState(T context)
    {
        Context = context;
    }

    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();
    public abstract void CheckSwitchStates();
    public abstract void InitializeSubState();

    public void UpdateStates()
    {
        CheckSwitchStates();
        UpdateState();

        if (CurrentSubState != null)
            CurrentSubState.UpdateStates();
    }

    protected void SwitchState(U newState)
    {
        ExitState();

        newState.EnterState();

        if (IsRootState)
            Context.CurrentState = newState;
        else if (CurrentSuperState != null)
            CurrentSuperState.SetSubState(newState);
    }
    protected void SetSuperState(HierarchicalState<T, U> newSuperState)
    {
        CurrentSuperState = newSuperState;
    }
    protected void SetSubState(HierarchicalState<T, U> newSubState)
    {
        CurrentSubState = newSubState;
        newSubState.SetSuperState(this);
    }
}
