using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IEditWorkoutForm
    {
        bool ShowForm();
        string WorkoutName { get; }
        double WorkoutEnergy { get; }
    }
}
