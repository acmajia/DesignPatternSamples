using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTest
{
    public abstract class Pizza
    {
        public Pizza(IIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        protected IIngredientFactory IngredientFactory { get; }

        public string Name { get; protected set; }
        public Sauce Sauce { get; protected set; }
        public Cheese Cheese { get; protected set; }
        public Clams Clams { get; protected set; }
        public Dough Dough { get; protected set; }

        public abstract void Prepare();
    }
}
