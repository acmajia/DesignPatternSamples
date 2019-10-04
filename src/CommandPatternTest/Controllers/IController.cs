using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternTest.Interfaces
{
    public interface IController
    {
        void AddButton(string name, ICommand command);
        void RemoveButton(string name);
        void ShowButtons();

        void ShowPressRecords(int numbers);
        void Undo(int numbers);

        void PressButton(string name);
    }
}
