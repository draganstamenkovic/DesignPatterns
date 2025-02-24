using UnityEngine;

namespace DesignPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
