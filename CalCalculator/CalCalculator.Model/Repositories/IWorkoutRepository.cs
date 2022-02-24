
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model.Repositories
{
    public interface IWorkoutRepository
    {
        int GetNewWorkoutId();
        int GetWorkoutIndexByName(string workoutName);
        Workout GetWorkoutById(int workoutId);
       // User GetWorkoutByName(string workoutName);
        List<Workout> GetAllWorkouts();
        List<int> GetAllWorkoutsIds();
        List<string> GetAllWorkoutsNames();
        Workout GetWorkoutByName(string workoutName);
        void AddWorkout(Workout workout);
        void DeleteWorkout(int index);
        void EditWorkout(string name, double energy, int index);
    }
}
