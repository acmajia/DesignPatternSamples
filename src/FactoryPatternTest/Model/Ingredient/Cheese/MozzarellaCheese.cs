using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTest
{
    public class MozzarellaCheese : Cheese
    {
        public override string Name { get; protected set; } = "Mozzarella cheese";
    }
}
