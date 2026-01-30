using UnityEngine;

namespace StatePattern
{
    public class IdleState : IState
    {
        private Animator _animator;
        public IdleState(Animator animator)
        {
            _animator = animator;
        }
        public void Enter()
        {
            _animator.SetBool("isMoving", false);
        }

        public void Exit()
        {
        }

        public void FixedUpdate(Vector3 moveDirection)
        {
        }
    }
}