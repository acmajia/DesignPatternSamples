using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternTest.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
