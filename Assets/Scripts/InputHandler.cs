using System.Collections.Generic;
using DesignPatterns.Command;
using UnityEngine;
using VContainer.Unity;

public class InputHandler : ITickable
{
    private readonly ICommandController _commandController;

    public InputHandler(ICommandController commandController)
    {
        _commandController = commandController;
    }

    public void Tick()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _commandController.Up();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _commandController.Left();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _commandController.Down();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _commandController.Right();
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            _commandController.Undo();
        }
    }
}
