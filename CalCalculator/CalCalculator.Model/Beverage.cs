using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    public class Beverage : Product
    {
        public Beverage(string name, double energyOn100ml)
            : base(name, energyOn100ml)
        {

        }
    }
}
