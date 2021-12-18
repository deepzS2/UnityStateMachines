using UnityEngine;

/// <summary>
/// Where the states should be used
/// </summary>
public abstract class StateManager : MonoBehaviour
{
    public State CurrentState { get; set; }

    public void SwitchState(State state)
    {
        CurrentState.ExitState();

        state.EnterState();

        CurrentState = state;
    }
}