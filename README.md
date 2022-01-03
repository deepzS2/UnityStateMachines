# State Machine and Hierarchical State Machine 
[![](https://img.shields.io/badge/lang-pt--BR-brightgreen)](README.pt-BR.md)

**State Machine** pattern is a behavioral software design pattern that allows an object to alter its behavior when its internal state changes. This pattern can be interpreted as a [strategy pattern](https://en.wikipedia.org/wiki/Strategy_pattern), which is abble to switch a strategy through invocations of methods defined in the pattern's interface. [- 🌐 Wikipedia](https://en.wikipedia.org/wiki/State_pattern)

**Hierarchical State Machine** design captures the commonality by organizing states as a hierarchy. The states at the higher level in hierarchy perform the common message handling, while the lower level states inherit the commonality from higher level ones and perform the state specific functions. [- EventHelix](https://www.eventhelix.com/design-patterns/hierarchical-state-machine/)

<br />

| ![](Images/State%20Machine.png) |
|:--:|
|*State Machine representation*|

<br />

| ![](Images/Hierarchical%20State%20Machine.png) |
|:--:|
|*Hierarchical State Machine representation*|

<br />

## How is it implemented?
*OBS: I used [IHeartGameDev](https://www.youtube.com/watch?v=Vt8aZDPzRjI) videos as reference to those scripts.*
## State Machine
The files with the abstract classes is in [State Machine folder](Assets/Scripts/State%20Machine) where [State.cs](Assets/Scripts/State%20Machine/State.cs) represents a state and [StateManager.cs](Assets/Scripts/State%20Machine/StateManager.cs) represents the manager where we should handle and store the states and execute the methods provided by the state on Unity MonoBehaviour.

### State.cs
In this file we have 4 methods, which we can always increase the complexity and add more methods. 

`EnterState()` is called when the previous state switched to the current state.

`UpdateState()` is called on Update MonoBehaviour method.

`ExitState()` is called when the current state switch to another state.

`CheckSwitchState()` is called on `UpdateState()` method to check for states we can switch to.

### StateManager.cs
In this file we only need a method to switch state and a attribute to store the current state.

`SwitchState(newState)` uses the `EnterState()` of the new state and `ExitState()` of the previous state.

<br />

| ![](Images/State%20Machine%20Implementation.png) |
|:--:|
|*Implementation representation*|

<br />

## Hierarchical State Machine
The files with the abstract classes is in [Hierarchical State Machine folder](Assets/Scripts/Hierarchical%20State%20Machine) where [HierarchicalState.cs](Assets/Scripts/Hierarchical%20State%20Machine/HierarchicalState.cs) represents the state, with properties of his hierarchy and [HierarchicalStateManager.cs](Assets/Scripts/Hierarchical%20State%20Machine/HierarchicalStateManager.cs) represents the manager where we should store the root state and execute the methods provided by the current state and his sub states.

### HierarchicalState.cs
In this file we have 9 methods, including the **State.cs** methods and access to the super state, sub state and context as well.

`UpdateStates()` is called on Update MonoBehaviour method to update the states of the whole hierarchy.

`SetSuperState(newSuperState)` is called when you set a new sub state, then the sub state need to know his parent.

`SetSubState(newSubState)` is called when you set a sub state.

`InitializeSubState()` is called on constructor of the class, to check which sub state we will initialize.

`SwitchState(newState)` is the same as **StateManager.cs** but we need to know if we are root state to switch it on Manager or set a new sub state.

### HierarchicalStateManager.cs
In this file we only need a attribute to store the current state, so the `SwitchState(newState)` method of **HierarchicalState.cs** can change it.

<br />

| ![](Images/Hierarchical%20State%20Machine%20Implementation.png) |
|:--:|
|*Implementation representation*|

<br />

## Examples
You can see the examples when running this repository on Unity. Accessing the Scenes files in the [Demos folder](Assets/Demos).
## TODO
- [ ] More examples;
- [x] Representations with images for better explanation on README;
- [x] Support to my native language (PT-BR);
- [x] Hierarchical state machine implementation.
