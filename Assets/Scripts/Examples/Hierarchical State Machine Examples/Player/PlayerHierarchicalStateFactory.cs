
public class PlayerHierarchicalStateFactory
{
    private PlayerHierarchicalStateManager _context;

    public PlayerHierarchicalStateFactory(PlayerHierarchicalStateManager context)
    {
        _context = context;
    }

    public PlayerBaseHierarchicalState Grounded()
    {
        return new PlayerHierarchicalGroundedState(_context, this);
    }

    public PlayerBaseHierarchicalState Jump()
    {
        return new PlayerHierarchicalJumpState(_context, this);
    }

    public PlayerBaseHierarchicalState Idle()
    {
        return new PlayerHierarchicalIdleState(_context, this);
    }

    public PlayerBaseHierarchicalState Walk()
    {
        return new PlayerHierarchicalWalkState(_context, this);
    }
}
