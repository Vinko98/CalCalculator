using System;
using CalCalculator.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IAddEnergyIntakeForm
    {
        bool ShowForm();
        DateTime EnergyTime { get; }
        User EnergyTo { get; }
        Meal EnergyFrom { get; }
    }
}
