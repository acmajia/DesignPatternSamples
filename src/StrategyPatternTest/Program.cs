using StrategyPatternTest.Subjects;
using System;

namespace StrategyPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var chinese = new Chinese();

            chinese.SpeakSomething();
            chinese.CheckWeapon();
            chinese.ArmWith(new Gun());
            chinese.Attack();
            chinese.Disarm();
            chinese.CheckWeapon();
            chinese.Attack();
            chinese.ArmWith(new LaserBeam());
            chinese.Attack();

            Console.Read();
        }
    }
}
