using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    public class Energy : Entity<int>
    {
        public Energy(double energyValue, string name, int id)
            : base(id)
        {
            this.Name = name;
            this.EnergyValue = energyValue;
        }

        public double EnergyValue { get; set; }
        public string Name { get; set; }
    }
}
