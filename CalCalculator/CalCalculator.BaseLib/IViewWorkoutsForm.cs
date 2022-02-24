using System;
using System.Collections.Generic;
using CalCalculator.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IViewWorkoutsForm
    {
        void ViewWorkouts(List<Workout> workouts, IMainFormController mainFormController);
    }
}
