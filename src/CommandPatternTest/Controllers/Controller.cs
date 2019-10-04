using CommandPatternTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace CommandPatternTest.Implements
{
    public class Controller : IController
    {
        public Controller() { }

        private readonly List<IButtion> buttons;
        private readonly BufferBlock<>

        public void AddButton(IButtion buttion)
        {
            buttons.Add(buttion);
        }

        public ICollection<IButtion> GetButtions()
        {
            return buttons;
        }

        public void PressButton(IButtion buttion)
        {

        }

        public void RemoveButton(IButtion buttion)
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
