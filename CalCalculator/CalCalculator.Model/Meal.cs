using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    public class Meal : Energy
    {
        public static readonly int UndefinedMealID = -1;
        public Meal(List<Product> products, int id, string name)
            : base(CalculateEnergy(products), name, id)
        {
            ProductsInMeal = new List<Product>(products);
            
        }

        public Meal(List<Product> products, string name)
            :base(CalculateEnergy(products), name, UndefinedMealID)
        {
            ProductsInMeal = new List<Product>(products);
            
        }

        public static double CalculateEnergy(List<Product> products)
        {
            double energySum = 0;
            foreach (Product product in products)
            {
                energySum += product.CalculateTotalEnergy();
            }
            return energySum;
        }

        public List<Product> ProductsInMeal { get; set; }
    }
}
