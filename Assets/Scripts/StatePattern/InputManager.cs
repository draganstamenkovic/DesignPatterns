using System;
using UnityEngine;

namespace StatePattern
{
    public class InputManager : MonoBehaviour, IInputManager
    {
        public Action OnIdle { get; set; }
        public Action<Vector3> OnRun { get; set; }
        
        private void CheckMovementInput()
        {
            if (Input.GetKeyDown(KeyCode.W))
                OnRun?.Invoke(Vector3.forward);
            else if (Input.GetKeyDown(KeyCode.S))
                OnRun?.Invoke(-Vector3.forward);
            else if (Input.GetKeyDown(KeyCode.A))
                OnRun?.Invoke(-Vector3.right);
            else if (Input.GetKeyDown(KeyCode.D))
                OnRun?.Invoke(Vector3.right);
            
            if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
                OnIdle?.Invoke();
        }

        private void Update()
        {
            CheckMovementInput();
        }
    }

    public interface IInputManager
    {
        Action OnIdle { get; set; }
        Action<Vector3> OnRun { get; set; }
    }
}