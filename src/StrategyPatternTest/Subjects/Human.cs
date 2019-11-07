using StrategyPatternTest.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternTest.Subjects
{
    public abstract class Human
    {
        private readonly ISpeakable _speakable;
        private IWeapon _weapon;

        public Human(ISpeakable speakable)
        {
            _speakable = speakable ?? throw new ArgumentNullException(nameof(speakable));
        }

        public void SpeakSomething()
        {
            _speakable.SpeakSomething();
        }

        public void Attack()
        {
            if (_weapon == null)
            {
                Console.WriteLine($"Oops, you're disarmed...");
                return;
            }

            _weapon.Use();
        }

        public void CheckWeapon()
        {
            if (_weapon == null)
            {
                Console.WriteLine($"This guy was disarmed.");
            }
            else
            {
                Console.WriteLine($"This guy armed with a(n) {_weapon.Name}");
            }
        }

        public void Disarm()
        {
            if (_weapon == null)
            {
                Console.WriteLine($"Already disarmed.");
            }
            else
            {
                Console.WriteLine($"Weapon {_weapon.Name} was disarmed.");
                _weapon = null;
            }
        }

        public void ArmWith(IWeapon weapon)
        {
            if (weapon == null)
            {
                return;
            }

            _weapon = weapon;
            Console.WriteLine($"Armed with a(n) {weapon.Name}.");
        }
    }
}
