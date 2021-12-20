using UnityEngine;

public class TreeStateFactory : MonoBehaviour
{
    private TreeStateManager _manager;

    public TreeStateFactory(TreeStateManager manager)
    {
        _manager = manager;
    }

    public TreeBaseState Growing()
    {
        return new TreeGrowingState(_manager, this);
    }

    public TreeBaseState Growed()
    {
        return new TreeGrowedState(_manager, this);
    }

    public TreeBaseState Chopped()
    {
        return new TreeChoppedState(_manager, this);
    }
}
