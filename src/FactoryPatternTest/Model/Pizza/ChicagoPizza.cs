using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTest
{
    public class ChicagoPizza : Pizza
    {
        public ChicagoPizza(IIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            Name = "Chicago pizza";
        }

        public override void Prepare()
        {
            Clams = IngredientFactory.CreateClams();
            Cheese = IngredientFactory.CreateCheese();
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
        }
    }
}
