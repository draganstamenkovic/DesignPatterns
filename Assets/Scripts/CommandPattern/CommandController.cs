using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command
{
    public class CommandController : ICommandController
    {
        private readonly IPlayerController _playerController;

        private Stack<ICommand> _commandHistory = new();
        private float _moveSpeed = 5f;

        public CommandController(IPlayerController playerController)
        {
            _playerController = playerController;
        }
        
        public void Left()
        {
            ICommand command = new MoveCommand(_playerController, new Vector3(-1, 0, 0), _moveSpeed);
            command.Execute();
            _commandHistory.Push(command);
        }

        public void Right()
        {
            ICommand command = new MoveCommand(_playerController, new Vector3(1, 0, 0), _moveSpeed);
            command.Execute();
            _commandHistory.Push(command);
        }

        public void Up()
        {
            ICommand command = new MoveCommand(_playerController, new Vector3(0, 0, 1), _moveSpeed);
            command.Execute();
            _commandHistory.Push(command);
        }

        public void Down()
        {
            ICommand command = new MoveCommand(_playerController, new Vector3(0, 0, -1), _moveSpeed);
            command.Execute();
            _commandHistory.Push(command);
        }

        public void Undo()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand lastCommand = _commandHistory.Pop();
                lastCommand.Undo();
            }
        }
    }
}