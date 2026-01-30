using UnityEngine;
using VContainer;

namespace StatePattern
{
    public class PlayerStateController : MonoBehaviour
    {
        [Inject] private readonly IInputManager _inputManager;
        [SerializeField] private Animator _animator;
        [SerializeField] private Rigidbody _rigidbody;
        private IState _idleState;
        private IState _runState;
        private GameStateMachine _gameStateMachine;
        private Vector3 _moveDirection = Vector3.zero;
        private readonly float _movementMultiplier = 3f;
        private void Awake()
        {
            _gameStateMachine = new GameStateMachine();
            _idleState = new IdleState(_animator);
            _runState = new RunState(_animator, _rigidbody, _movementMultiplier);
            _gameStateMachine.ChangeState(_idleState);
        }
        private void OnEnable()
        {
            _inputManager.OnIdle += OnIdle;
            _inputManager.OnRun += OnRun;
        }

        private void OnDisable()
        {
            _inputManager.OnIdle -= OnIdle;
            _inputManager.OnRun -= OnRun;
        }
        private void OnIdle()
        {
            _moveDirection = Vector3.zero;
            _gameStateMachine.ChangeState(_idleState);
        }

        private void OnRun(Vector3 moveDirection)
        {
            _moveDirection = moveDirection;
            _gameStateMachine.ChangeState(_runState);
        }
        
        private void FixedUpdate()
        {
            _gameStateMachine.CurrentState?.FixedUpdate(_moveDirection);
        }
    }
}