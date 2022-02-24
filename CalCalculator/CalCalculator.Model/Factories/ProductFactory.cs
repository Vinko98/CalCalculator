using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model.Factories
{
    public class ProductFactory
    {

		public static Product CreateProduct(string name, string type, double energyOn100)
		{
			Product product = null;

			switch (type)
			{
				case "Food":
					product = new Food(name, energyOn100);
					break;
				case "Beverage":
					product = new Beverage(name, energyOn100);
					break;
				default:
					throw new WrongProductTypeInString();
			}

			return product;
		}
	}
}
