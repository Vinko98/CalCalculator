using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    public class Workout : Energy
    {
        public Workout(double energyValue, string name, int id)
            : base(energyValue, name, id)
        {
        }
    }
}
