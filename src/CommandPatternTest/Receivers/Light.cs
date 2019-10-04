using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternTest.Receivers
{
    public class Light
    {
        private LightState _currentState;

        public void On()
        {
            if (_currentState == LightState.Off)
            {
                _currentState = LightState.On;
                Console.WriteLine("This light has turned on!");
            }
            else
            {
                Console.WriteLine("This light has already been turned on!");
            }
        }

        public void Off()
        {
            if (_currentState == LightState.On)
            {
                _currentState = LightState.Off;
                Console.WriteLine("This light has turned off!");
            }
            else
            {
                Console.WriteLine("This light has already been turned off!");
            }
        }

        public LightState GetCurrentState()
        {
            return _currentState;
        }
    }

    public enum LightState
    {
        On = 0,
        Off = 1
    }
}
