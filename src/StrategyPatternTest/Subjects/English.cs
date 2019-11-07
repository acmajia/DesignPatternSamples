using System;
using System.Collections.Generic;
using System.Text;
using StrategyPatternTest.Behaviors;

namespace StrategyPatternTest.Subjects
{
    public class English : Human
    {
        public English() : base(new EnglishSpeaking())
        {
        }
    }
}
