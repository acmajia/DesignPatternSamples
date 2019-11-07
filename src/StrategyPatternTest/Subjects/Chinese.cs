using System;
using System.Collections.Generic;
using System.Text;
using StrategyPatternTest.Behaviors;

namespace StrategyPatternTest.Subjects
{
    public class Chinese : Human
    {
        public Chinese() : base(new ChineseSpeaking())
        {
        }
    }
}
