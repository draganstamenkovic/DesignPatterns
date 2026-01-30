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
            Debug.Log("Entering Run State");
            _animator.SetBool("isMoving", true);
        }

        public void Exit()
        {
            Debug.Log("Exiting Run State");
        }
        
        public void FixedUpdate(Vector3 moveDirection)
        {
            if (moveDirection == Vector3.zero) return;
            var movePosition = moveDirection * _movementMultiplier;
            Debug.Log("Speed: " + _movementMultiplier + " | Move Position: " + movePosition + " | Move Direction: " + moveDirection);
            _rigidbody.linearVelocity = movePosition;
        }
    }
}