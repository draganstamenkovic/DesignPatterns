using UnityEngine;

namespace StatePattern
{
    public interface IState
    {
        void Enter();
        void Exit();
        void FixedUpdate(Vector3 moveDirection);
    }
}