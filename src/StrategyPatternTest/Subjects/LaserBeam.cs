using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternTest.Subjects
{
    public class LaserBeam : IWeapon
    {
        public string Name => "Laser Beam";

        public void Use()
        {
            Console.WriteLine("Bi~Bi~Bi~~~~!");
        }
    }
}
