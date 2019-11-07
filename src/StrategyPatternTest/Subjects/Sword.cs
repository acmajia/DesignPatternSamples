using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternTest.Subjects
{
    public class Sword : IWeapon
    {
        public string Name => "Sword";

        public void Use()
        {
            Console.WriteLine("Phew~Phew~Phew~");
        }
    }
}
