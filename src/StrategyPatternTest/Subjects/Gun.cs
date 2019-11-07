using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternTest.Subjects
{
    public class Gun : IWeapon
    {
        public string Name => "Gun";

        public void Use()
        {
            Console.WriteLine("Pew!Pew!Pew!");
        }
    }
}
