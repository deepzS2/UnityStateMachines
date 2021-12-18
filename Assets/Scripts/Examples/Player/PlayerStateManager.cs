using UnityEngine;
using UnityEngine.UI;

public class PlayerStateManager : StateManager
{
    [SerializeField] private Text _stateText;
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private float _jumpHeight = 1f;

    private PlayerStateFactory _states;
    private CharacterController _controller;
    private Animator _animator;
    private Vector3 _playerVelocity;
    private bool _isGrounded;
    private float _gravityValue = -9.81f;
    private float _horizontalInput;

    public CharacterController Controller => _controller;
    public Animator Animator => _animator;
    public float PlayerVelocityY { get => _playerVelocity.y; set => _playerVelocity.y = value; }
    public float JumpHeight => _jumpHeight;
    public float GravityValue => _gravityValue;
    public float HorizontalInput => _horizontalInput;
    public float Speed => _speed;
    public bool IsGrounded => _isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
        _states = new PlayerStateFactory(this);

        CurrentState = _states.Idle();
        CurrentState.EnterState();
    }

    // Update is called once per frame
    void Update()
    {
        _isGrounded = _controller.isGrounded;
        _horizontalInput = Input.GetAxis("Horizontal");

        CurrentState.UpdateState();

        HandleGravity();
    }

    void LateUpdate()
    {
        Vector3 viewPos = transform.position;

        viewPos.x = Mathf.Clamp(viewPos.x, -5.13f, 5.13f);
        viewPos.y = Mathf.Clamp(viewPos.y, -3.82f, 3.82f);

        transform.position = viewPos;
    }

    void HandleGravity()
    {
        if (_isGrounded && _playerVelocity.y < 0)
        {
            _playerVelocity.y = -0.01f;
        }

        _playerVelocity.y += _gravityValue * Time.deltaTime;
        _controller.Move(_playerVelocity * Time.deltaTime);
    }

    public void SetText(string text)
    {
        _stateText.text = text;
    }
}
