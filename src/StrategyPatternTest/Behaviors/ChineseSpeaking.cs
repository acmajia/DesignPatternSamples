using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternTest.Behaviors
{
    public class ChineseSpeaking : ISpeakable
    {
        public void SpeakSomething()
        {
            Console.WriteLine("爱慕拆尼斯！");
        }
    }
}
