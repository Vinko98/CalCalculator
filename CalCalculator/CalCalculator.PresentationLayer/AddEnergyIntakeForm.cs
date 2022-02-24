using System;
using System.Collections.Generic;
using CalCalculator.Model.Repositories;
using CalCalculator.BaseLib;
using CalCalculator.Model;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCalculator.PresentationLayer
{
    public partial class AddEnergyIntakeForm : Form, IAddEnergyIntakeForm
    {
        private readonly List<string> MealsNames = null;
        private readonly List<string> UserNames = null;
        private readonly IMealRepository mealRepository = null;
        private readonly IUserRepository userRepository = null;
        public AddEnergyIntakeForm(IMealRepository mealRepository, IUserRepository userRepository)
        {
            MealsNames = mealRepository.GetAllMealsNames();
            UserNames = userRepository.GetAllUsersNames();
            this.mealRepository = mealRepository;
            this.userRepository = userRepository;
            InitializeComponent();
        }

        private void AddEnergyExchangeForm_Load(object sender, EventArgs e)
        {
            foreach (string s in MealsNames)
                comboBoxEnergyFrom.Items.Add(s);

            foreach (string s in UserNames)
                comboBoxEnergyTo.Items.Add(s);
        }

        public bool ShowForm()
        {
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }

        public DateTime EnergyTime => dateTimePickerEnergy.Value;
        public Meal EnergyFrom => mealRepository.GetMealByName(comboBoxEnergyFrom.Text);
        public User EnergyTo => userRepository.GetUserByName(comboBoxEnergyTo.Text);

    }
}
