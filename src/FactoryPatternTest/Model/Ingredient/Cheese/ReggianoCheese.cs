﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTest
{
    public class ReggianoCheese : Cheese
    {
        public override string Name { get; protected set; } = "Reggiano cheese";
    }
}
