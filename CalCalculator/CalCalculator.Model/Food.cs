using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    public class Food : Product
    {

        public Food(string name, double energyOn100g)
            : base(name, energyOn100g)
        {
        }
        
    }
}
