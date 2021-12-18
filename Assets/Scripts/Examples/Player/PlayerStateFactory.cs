using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateFactory
{
    private PlayerStateManager _manager;

    public PlayerStateFactory(PlayerStateManager manager)
    {
        _manager = manager;
    }

    public PlayerBaseState Idle()
    {
        return new PlayerIdleState(_manager, this);
    }

    public PlayerBaseState Walking()
    {
        return new PlayerWalkingState(_manager, this);
    }

    public PlayerBaseState Jump()
    {
        return new PlayerJumpState(_manager, this);
    }
}
