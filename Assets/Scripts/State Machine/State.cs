using System;

// Note that you can add more methods here!
// Example: FixedUpdateState(), OnCollideState(), etc.

/// <summary>
/// State abstract class 
/// </summary>
public abstract class State
{
    /// <summary>
    /// Called when entering the state
    /// </summary>
    public virtual void EnterState() { }

    /// <summary>
    /// Called on Update() MonoBehaviour method
    /// </summary>
    public virtual void UpdateState()
    {
        CheckSwitchState();
    }

    /// <summary>
    /// Called when switching to another state
    /// </summary>
    public virtual void ExitState() { }

    /// <summary>
    /// Called On UpdateState(), it should have all the states it can switch to
    /// </summary>
    protected abstract void CheckSwitchState();
}
