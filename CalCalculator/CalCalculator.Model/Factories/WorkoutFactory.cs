using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model.Factories
{
    public class WorkoutFactory
    {
        public static Workout CreateWorkout(string name, double energy, int id)
        {
            return new Workout(energy, name, id);
        }
    }
}
