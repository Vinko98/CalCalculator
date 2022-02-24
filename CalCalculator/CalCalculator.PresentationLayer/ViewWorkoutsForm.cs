using System;
using CalCalculator.BaseLib;
using CalCalculator.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCalculator.PresentationLayer
{
    public partial class ViewWorkoutsForm : Form, IViewWorkoutsForm
    {
        private List<Workout> workouts = null;
        private IMainFormController mainFormController = null;
        public ViewWorkoutsForm()
        {
            InitializeComponent();
        }
        public void ViewWorkouts(List<Workout> workouts, IMainFormController mainFormController)
        {
            this.mainFormController = mainFormController;
            this.workouts = workouts;
            DisplayWorkouts();
            this.Show();
        }
        private void DisplayWorkouts()
        {
            for (int i = 0; i < workouts.Count(); i++)
            {
                Workout workout = workouts[i];

                string workoutName = workout.Name;
                string workoutEnergy = workout.EnergyValue.ToString();

                ListViewItem workoutRow = new ListViewItem(workoutName);
                workoutRow.SubItems.Add(workoutEnergy);

                listViewWorkouts.Items.Add(workoutRow);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mainFormController.EditWorkout(listViewWorkouts);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mainFormController.DeleteWorkout(listViewWorkouts);
        }
    }
}
