using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    public class Product
    {
        public Product(string name, double energyOn100)
        {
            Name = name;
            EnergyOn100 = energyOn100;
 //           Amount = amount;
        }

        public double CalculateTotalEnergy()
        {
            return (this.Amount / 100) * this.EnergyOn100;
        }

        public string Name { get; set; }
        public double EnergyOn100 { get; set; }
        public double Amount { get; set; }
    }
}
