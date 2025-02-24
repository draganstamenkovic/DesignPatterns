
using UnityEngine;

namespace DesignPatterns.Command
{
    public class MoveCommand : ICommand
    {
        private readonly IPlayerController _player;
        private Vector3 _direction;
        private float _speed;
        
        public MoveCommand(IPlayerController player, Vector3 direction, float speed)
        {
            _player = player;
            _direction = direction;
            _speed = speed;
        }

        public void Execute()
        {
            _player.Move(_direction * _speed);
        }

        public void Undo()
        {
            _player.Move(-_direction * _speed);
        }
    }
}
