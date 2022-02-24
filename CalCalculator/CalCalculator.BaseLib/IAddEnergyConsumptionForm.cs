using System;
using CalCalculator.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IAddEnergyConsumptionForm
    {
        bool ShowForm();
        DateTime EnergyTime { get; }
        User EnergyFrom { get; }
        Workout EnergyTo { get; }
    }
}
