using System;

namespace CommandPatternTest.Interfaces
{
    public interface IButtion
    {
        string Name { get; }
        ICommand Command { get; }
        EventHandler OnPressed { get; set; }
        void Undo();

        void SetCommand(ICommand command);
    }
}