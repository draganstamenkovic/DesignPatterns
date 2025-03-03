using UnityEngine;

public class PlayerController : MonoBehaviour, IPlayerController
{
    [SerializeField] private Rigidbody _rigidbody;
    
    public void Move(Vector3 velocity)
    {
        _rigidbody.linearVelocity = velocity;
    }
}
