using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model.Factories
{
    public class EnergyExchangeFactory
    {
        public static EnergyExchange CreateEnergyExchange(DateTime energyTime, Energy energyFrom, Energy energyTo, int id)
        {
            return new EnergyExchange(energyTime, energyFrom, energyTo, id);
        }
    }
}
