using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : State
{
    protected PlayerStateManager Context;
    protected PlayerStateFactory Factory;

    public PlayerBaseState(PlayerStateManager context, PlayerStateFactory factory)
    {
        Context = context;
        Factory = factory;
    }
}
