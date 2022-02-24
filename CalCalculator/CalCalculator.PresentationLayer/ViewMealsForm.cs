using System;
using CalCalculator.BaseLib;
using CalCalculator.Model;
using CalCalculator.Model.Repositories;
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
    public partial class ViewMealsForm : Form, IViewMealsForm
    {
        private List<Meal> mealsForm = null;
        private IMainFormController mainFormController = null;
        private IMealRepository mealRepository = null;
        public ViewMealsForm()
        {
            InitializeComponent();
        }

        public void ViewMeals(List<Meal> meals, IMainFormController mainFormController, IMealRepository mealRepository)
        {
            this.mainFormController = mainFormController;
            this.mealRepository = mealRepository;
            mealsForm = meals;
            DisplayMeals();
            this.Show();
        }

        private void DisplayMeals()
        {
            for (int i = 0; i < mealsForm.Count(); i++)
            {
                Meal meal = mealsForm[i];

                string mealName = meal.Name;
                string mealTotalEnergy = mealRepository.GetTotalMealEnergyByMealName(mealName).ToString();
                //List<string> productNames = mealRepository.GetAllProductNamesByMealName(mealName);

                ListViewItem mealRow = new ListViewItem(mealName);
                mealRow.SubItems.Add(mealTotalEnergy);

                listViewMeals.Items.Add(mealRow);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mainFormController.EditMeal(listViewMeals);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mainFormController.DeleteMeal(listViewMeals);
        }


    }
}
