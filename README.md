# State Machine 
[![](https://img.shields.io/badge/lang-pt--BR-brightgreen)](README.pt-BR.md)

**State Machine** pattern is a behavioral software design pattern that allows an object to alter its behavior when its internal state changes. This pattern can be interpreted as a [strategy pattern](https://en.wikipedia.org/wiki/Strategy_pattern), which is abble to switch a strategy through invocations of methods defined in the pattern's interface. [- 🌐 Wikipedia](https://en.wikipedia.org/wiki/State_pattern)

## How is it implemented?
The files with the abstract classes is in [State Machine folder](Assets/Scripts/State%20Machine) where [State.cs](Assets/Scripts/State%20Machine/State.cs) represents a state and [StateManager.cs](Assets/Scripts/State%20Machine/StateManager.cs) represents the manager where we should handle the states with Unity MonoBehaviour.

OBS: I used [IHeartGameDev](https://www.youtube.com/watch?v=Vt8aZDPzRjI) videos as reference to those scripts.

### State.cs
In this file we have 4 methods, which we can always increase the complexity and add more methods. 

`EnterState()` is called when the previous state switched to the current state.

`UpdateState()` is called on Update MonoBehaviour method.

`ExitState()` is called when the current state switch to another state.

`CheckSwitchState()` is called on `UpdateState()` method to check for states we can switch to.

### StateManager.cs
In this file we only need a method to switch state and a attribute to store the current state.

`SwitchState(newState)` uses the `EnterState()` of the new state and `ExitState()` of the previous state.

## Examples
You can see the examples when running this repository on Unity. Accessing the Scenes files in the [Demos folder](Assets/Demos).

## TODO
- [ ] More examples;
- [ ] Representations with images for better explanation on README;
- [x] Support to my native language (PT-BR);
- [ ] Hierarchical state machine implementation.