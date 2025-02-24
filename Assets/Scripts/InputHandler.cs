using System.Collections.Generic;
using DesignPatterns.Command;
using UnityEngine;
using VContainer.Unity;

public class InputHandler : ITickable
{
    private Stack<ICommand> _commandHistory = new();
    private readonly IPlayerController _playerController;
    private float _moveSpeed = 5f;
    
    
    public InputHandler(IPlayerController playerController)
    {
        _playerController = playerController;
    }
    
    public void Tick()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ICommand command = new MoveCommand(_playerController, new Vector3(0, 0, 1), _moveSpeed);
            command.Execute();
            _commandHistory.Push(command);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ICommand command = new MoveCommand(_playerController, new Vector3(-1, 0, 0), _moveSpeed);
            command.Execute();
            _commandHistory.Push(command);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ICommand command = new MoveCommand(_playerController, new Vector3(0, 0, -1), _moveSpeed);
            command.Execute();
            _commandHistory.Push(command);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ICommand command = new MoveCommand(_playerController, new Vector3(1, 0, 0), _moveSpeed);
            command.Execute();
            _commandHistory.Push(command);
        }
        else if (Input.GetKeyDown(KeyCode.Z) && _commandHistory.Count > 0)
        {
            ICommand lastCommand = _commandHistory.Pop();
            lastCommand.Undo();
        }
    }
}
