using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    public class EnergyExchange : Entity<int>
    {
        public EnergyExchange(DateTime time, Energy energyFrom, Energy energyTo, int id)
            : base(id)
        {
            Time = time;
            EnergyFrom = energyFrom;
            EnergyTo = energyTo;
        }

        public DateTime Time { get; set; }
        public Energy EnergyFrom { get; set; }
        public Energy EnergyTo { get; set; }

    }
}
