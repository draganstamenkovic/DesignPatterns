using UnityEngine;

public class PlayerController : MonoBehaviour, IPlayerController
{
    [SerializeField] private Rigidbody _rigidbody;
    
    public void Move(Vector3 velocity)
    {
        //var newVelocity = new Vector2(velocity, _rigidbody.linearVelocity.y);
        _rigidbody.linearVelocity = velocity;
    }
}
