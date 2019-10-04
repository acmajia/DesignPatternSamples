using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTest
{
    public class NeapolitanPizza : Pizza
    {
        public NeapolitanPizza(IIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }

        public override string Name => throw new NotImplementedException();

        public override Sauce Sauce => throw new NotImplementedException();

        public override Cheese Cheese => throw new NotImplementedException();

        public override Clams Clams => throw new NotImplementedException();

        public override Dough Dough => throw new NotImplementedException();

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
