using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTest
{
    public abstract class Dough
    {
        public abstract string Name { get; protected set; }
    }
}
