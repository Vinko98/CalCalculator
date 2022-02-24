using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    class EnergyIntake : EnergyExchange
    {
        public EnergyIntake(DateTime time, Meal energyFrom, User energyTo, int id)
            : base(time, energyFrom, energyTo, id)
        {
            
        }

     
    }
}
