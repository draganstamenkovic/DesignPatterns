using UnityEngine;

namespace StatePattern
{
    public class IdleState : IState
    {
        private Animator _animator;
        private Rigidbody _rigidbody;
        public IdleState(Animator animator, Rigidbody rigidbody)
        {
            _animator = animator;
            _rigidbody = rigidbody;
        }
        public void Enter()
        {
            Debug.Log("Entering Idle State");
            _animator.SetBool("isMoving", false);
        }

        public void Exit()
        {
            Debug.Log("Exiting Idle State");
        }

        public void FixedUpdate(Vector3 moveDirection)
        {
        }
    }
}