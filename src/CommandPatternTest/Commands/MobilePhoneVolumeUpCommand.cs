using CommandPatternTest.Interfaces;
using CommandPatternTest.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternTest.Commands
{
    class MobilePhoneVolumeUpCommand : ICommand
    {
        public MobilePhoneVolumeUpCommand(MobilePhone mobilePhone)
        {
            Receiver = mobilePhone;
        }

        public MobilePhone Receiver { get; }

        public void Execute()
        {
            Receiver.VolumeUp();
        }

        public void Undo()
        {
            Receiver.VolumeDown();
        }
    }
}
