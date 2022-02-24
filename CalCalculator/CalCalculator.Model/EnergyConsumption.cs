using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    class EnergyConsumption : EnergyExchange
    {
        public EnergyConsumption(DateTime time, User energyFrom, Workout energyTo, int id)
            : base(time, energyFrom, energyTo, id)
        {

        }
    }
}
