using CommandPatternTest.Interfaces;
using CommandPatternTest.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternTest.Commands
{
    public class LightOnCommand : ICommand
    {
        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public Light Light { get; }
        private 

        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}
