using CommandPatternTest.Implements;
using System;

namespace CommandPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller();
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);

            var mobilePhone = new MobilePhone();
            var mobilePhoneVolumeUpCommand = new MobilePhoneVolumeUpCommand(mobilePhone);

            controller.SetCommand(lightOnCommand);
            controller.Execute();

            controller.SetCommand(mobilePhoneVolumeUpCommand);
            controller.Execute();

            Console.ReadKey();
        }
    }
}
