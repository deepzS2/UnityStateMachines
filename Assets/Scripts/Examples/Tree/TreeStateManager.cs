using UnityEngine;
using UnityEngine.UI;

public class TreeStateManager : StateManager
{
    [SerializeField] private Text _stateText;
    [SerializeField] private float _growingTime = 5f;
    [SerializeField] private float _growedScale = 1.5f;
    [SerializeField] private float _choppedRotation = -81f;

    private TreeStateFactory _states;
    private Vector3 _previousScale;

    public Vector3 GrowedScale => Vector3.one * _growedScale;
    public float GrowingTime => _growingTime;
    public float ChoppedRotation => _choppedRotation;
    public bool ChopTree => Input.GetKeyDown(KeyCode.Space);

    private void Awake()
    {
        _states = new TreeStateFactory(this);
    }

    private void Start()
    {
        CurrentState = _states.Growing();
        CurrentState.EnterState();

        _previousScale = transform.localScale;
    }

    private void Update()
    {
        CurrentState.UpdateState();

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale = _previousScale;
            transform.localEulerAngles = Vector3.zero;

            CurrentState = _states.Growing();
            CurrentState.EnterState();
        }
    }

    public void SetText(string text)
    {
        _stateText.text = text;
    }
}
