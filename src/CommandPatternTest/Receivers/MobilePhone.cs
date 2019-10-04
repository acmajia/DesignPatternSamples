using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternTest.Receivers
{
    public class MobilePhone
    {
        private int _currentVolume;
        private MobilePhoneState _currentState;
        private const int MaxVolume = 10;
        private const int MinVolume = 0;

        public void StartUp()
        {
            _currentState = MobilePhoneState.On;
            Console.WriteLine("Mobile phone has started up!");
        }

        public void ShutDown()
        {
            _currentState = MobilePhoneState.Off;
            Console.WriteLine("Mobile phone has shut down");
        }

        public MobilePhoneState GetCurrentState()
        {
            return _currentState;
        }

        public void VolumeUp()
        {
            if (_currentVolume < MaxVolume)
            {
                _currentVolume++;
                Console.WriteLine("Mobile volume has turned up!");
            }
            else
            {
                Console.WriteLine("Already max volume!");
            }
        }

        public void VolumeDown()
        {
            if (_currentVolume > MinVolume)
            {
                _currentVolume--;
                Console.WriteLine("Mobile volume has turned down");
            }
            else
            {
                Console.WriteLine("Already min volume!");
            }
        }

        public int GetCurrentVolume()
        {
            return _currentVolume;
        }
    }

    public enum MobilePhoneState
    {
        On,
        Off
    }
}
