using System;
using CalCalculator.Model;
using System.Collections.Generic;
using CalCalculator.Model.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.MemoryBasedDAL
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private static int id = 1;
        private readonly List<Workout> workouts = new List<Workout>();

        public int GetNewWorkoutId()
        {
            int nextId = id;
            id++;
            return nextId;
        }

        public Workout GetWorkoutById(int workoutId)
        {
            var workout = (from l in workouts where l.Id == workoutId select l).First();
            return workout;
        }

        public int GetWorkoutIndexByName(string workoutName)
        {
            var workout = (from l in workouts where l.Name == workoutName select l).First();
            if (workout != null)
            {
                return workouts.IndexOf(workout);
            }
            throw new WorkoutDoesntExist();
        }

        public List<string> GetAllWorkoutsNames()
        {
            return workouts.Select(a => a.Name).ToList();
        }

        public Workout GetWorkoutByName(string workoutName)
        {
            var workout = (from l in workouts where l.Name == workoutName select l).First();

            if (workout != null)
                return workout;

            throw new WorkoutDoesntExist();
        }

        //public Workout GetWorkoutByName(string workoutName)
        //{
        //    var workout = (from l in workouts where l.Name == workoutName select l).First();
        //
        //    if (meal != null)
        //        return meal;
        //
        //    throw new MealDoesntExist();
        //}

        public List<Workout> GetAllWorkouts()
        {
            return workouts;
        }

        public List<int> GetAllWorkoutsIds()
        {
            return workouts.Select(workout => workout.Id).ToList();
        }

        public void AddWorkout(Workout newWorkout)
        {
            if (workouts.Any(workout => workout.Id == newWorkout.Id))
            {
                throw new WorkoutAlreadyExists();
            }
            else
            {
                workouts.Add(newWorkout);
            }
        }

        public void EditWorkout(string name, double energy, int index)
        {
            workouts[index].Name = name;
            workouts[index].EnergyValue = energy;
        }
        public void DeleteWorkout(int index)
        {
            workouts.RemoveAt(index);
        }
    }
}
