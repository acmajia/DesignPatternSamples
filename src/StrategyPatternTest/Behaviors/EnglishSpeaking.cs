using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternTest.Behaviors
{
    public class EnglishSpeaking : ISpeakable
    {
        public void SpeakSomething()
        {
            Console.WriteLine("Hello, this is Gabe Newell.");
        }
    }
}
