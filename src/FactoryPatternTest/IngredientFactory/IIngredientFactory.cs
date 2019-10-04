using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTest
{
    public interface IIngredientFactory
    {
        Sauce CreateSauce();
        Clams CreateClams();
        Cheese CreateCheese();
        Dough CreateDough();
    }
}
