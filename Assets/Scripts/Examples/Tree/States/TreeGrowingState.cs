using UnityEngine;

public class TreeGrowingState : TreeBaseState
{
    private float _currentLerpTime;
    private Vector3 _startScale;
    private GameObject gameObject;


    public TreeGrowingState(TreeStateManager context, TreeStateFactory factory) : base(context, factory)
    {
    }

    public override void EnterState()
    {
        Context.SetText("Growing");
        gameObject = Context.gameObject;
        _currentLerpTime = 0;
        _startScale = Context.transform.localScale;
    }

    public override void UpdateState()
    {
        base.UpdateState();

        _currentLerpTime += Time.deltaTime;

        float perc = _currentLerpTime / Context.GrowingTime;
        gameObject.transform.localScale = Vector3.Lerp(_startScale, Context.GrowedScale, perc);
    }

    protected override void CheckSwitchState()
    {
        if (Context.transform.localScale.magnitude >= Context.GrowedScale.magnitude)
        {
            Context.SwitchState(Factory.Growed());
        }
    }
}
