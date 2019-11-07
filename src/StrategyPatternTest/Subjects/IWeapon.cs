using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternTest.Subjects
{
    public interface IWeapon
    {
        string Name { get; }
        void Use();
    }
}
