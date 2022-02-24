using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model.Factories
{
    public class MealFactory
    {
        public static Meal CreateMeal(List<Product> products, string name)
        {
            return new Meal(products, name);
        }
    }
}
