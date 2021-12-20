using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeChoppedState : TreeBaseState
{
    private float _currentLerpTime;
    private float _time = 1.5f;
    private Vector3 _startRotation;
    private GameObject gameObject;

    public TreeChoppedState(TreeStateManager context, TreeStateFactory factory) : base(context, factory)
    {
    }

    public override void EnterState()
    {
        Context.SetText("Chopped");
        gameObject = Context.gameObject;
        _currentLerpTime = 0;
    }

    public override void UpdateState()
    {
        base.UpdateState();

        _currentLerpTime += Time.deltaTime;

        float perc = _currentLerpTime / _time;
        gameObject.transform.eulerAngles = Vector3.Lerp(Vector3.zero, new Vector3(0, 0, Context.ChoppedRotation), perc);
    }

    protected override void CheckSwitchState() { }
}
