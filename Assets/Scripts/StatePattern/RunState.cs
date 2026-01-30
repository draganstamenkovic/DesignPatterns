using UnityEngine;

namespace StatePattern
{
    public class RunState : IState
    {
        private readonly Animator _animator;
        private readonly Rigidbody _rigidbody;
        private readonly float _movementMultiplier;
        public RunState(Animator animator, Rigidbody rigidbody, float movementMultiplier)
        {
            _animator = animator;
            _rigidbody = rigidbody;
            _movementMultiplier = movementMultiplier;
        }
        public void Enter()
        {
            _animator.SetBool("isMoving", true);
        }

        public void Exit()
        {
        }
        
        public void FixedUpdate(Vector3 moveDirection)
        {
            if (moveDirection == Vector3.zero) return;
            var movePosition = moveDirection * _movementMultiplier;
            _rigidbody.linearVelocity = movePosition;
        }
    }
}