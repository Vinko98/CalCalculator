using System;
using System.Collections.Generic;
using CalCalculator.BaseLib;
using CalCalculator.Model.Repositories;
using System.Windows.Forms;
using CalCalculator.Model;
using CalCalculator.Model.Factories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Controllers
{
    class WorkoutController
    {
		public void AddWorkout(IAddWorkoutForm form, IWorkoutRepository workoutRepository)
		{
			if (form.ShowForm() == true)
			{
				try
				{
					string name = form.WorkoutName;
					double energy = form.WorkoutEnergy;
					

					int id = workoutRepository.GetNewWorkoutId();

					Workout workout = WorkoutFactory.CreateWorkout(name, energy, id);
					workoutRepository.AddWorkout(workout);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void ViewWorkouts(IViewWorkoutsForm viewWorkoutsForm, IWorkoutRepository workoutRepository, IMainFormController mainFormController)
		{
			List<Workout> workouts = workoutRepository.GetAllWorkouts();
			viewWorkoutsForm.ViewWorkouts(workouts, mainFormController);
		}

		public void EditWorkout(IEditWorkoutForm form, IWorkoutRepository workoutRepository, ListView listView, int index)
		{
			if (form.ShowForm() == true)
			{
				try
				{

					string name = form.WorkoutName;
					double energy = form.WorkoutEnergy;
					
					//double pAmount = form.Amount;
					listView.SelectedItems[0].Text = form.WorkoutName;
					listView.SelectedItems[0].SubItems[1].Text = form.WorkoutEnergy.ToString();
					//listView.SelectedItems[0].SubItems[3].Text = form.Amount.ToString();

					workoutRepository.EditWorkout(name, energy, index);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void DeleteWorkout(IWorkoutRepository workoutRepository, ListView listView, int index)
		{
			foreach (ListViewItem item in listView.SelectedItems)
			{
				listView.Items.Remove(item);
			}

			workoutRepository.DeleteWorkout(index);
		}
	}
}
