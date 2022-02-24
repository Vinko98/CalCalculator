using System;
using System.Collections.Generic;
using CalCalculator.Model.Repositories;
using CalCalculator.Model;
using CalCalculator.BaseLib;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCalculator.PresentationLayer
{
    public partial class AddEnergyConsumptionForm : Form, IAddEnergyConsumptionForm
    {
        private readonly List<string> WorkoutsNames = null;
        private readonly List<string> UsersNames = null;
        private readonly IWorkoutRepository workoutRepository = null;
        private readonly IUserRepository userRepository = null;
        public AddEnergyConsumptionForm(IWorkoutRepository workoutRepository, IUserRepository userRepository)
        {
            WorkoutsNames = workoutRepository.GetAllWorkoutsNames();
            UsersNames = userRepository.GetAllUsersNames();
            this.workoutRepository = workoutRepository;
            this.userRepository = userRepository;
            InitializeComponent();
        }
        public bool ShowForm()
        {
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }

        public DateTime EnergyTime => dateTimePickerEnergy.Value;
        public User EnergyFrom => userRepository.GetUserByName(comboBoxEnergyFrom.Text);
        public Workout EnergyTo => workoutRepository.GetWorkoutByName(comboBoxEnergyTo.Text);

        private void AddEnergyConsumptionForm_Load(object sender, EventArgs e)
        {
            foreach (string s in UsersNames)
                comboBoxEnergyFrom.Items.Add(s);

            foreach (string s in WorkoutsNames)
                comboBoxEnergyTo.Items.Add(s);
        }
    }
}
