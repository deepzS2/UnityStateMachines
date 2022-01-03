using UnityEngine;

/// <summary>
/// Where the states should be used
/// </summary>
public abstract class StateManager : MonoBehaviour
{
    private State _currentState;
    public State CurrentState { get => _currentState; set => _currentState = value; }

    public void SwitchState(State state)
    {
        CurrentState.ExitState();

        state.EnterState();

        CurrentState = state;
    }
}