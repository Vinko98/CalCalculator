using CalCalculator.BaseLib;
using CalCalculator.Model.Repositories;
using CalCalculator.Model;
using CalCalculator.Model.Factories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Controllers
{
    class MealController
    {
		public void AddMeal(IAddMealForm form, IMealRepository mealRepository)
		{
			if (form.ShowForm() == true)
			{
				try
				{
					string name = form.MealName;
					List<Product> mealProducts = form.GetMealProducts();

					Meal meal = MealFactory.CreateMeal(mealProducts, name);
					mealRepository.AddMeal(meal);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void ViewMeals(IViewMealsForm viewMealsForm, IMealRepository mealRepository, IMainFormController mainFormController)
		{
			List<Meal> meals = mealRepository.GetAllMeals();
			viewMealsForm.ViewMeals(meals, mainFormController, mealRepository);
		}

		public void EditMeal(IEditMealForm form, IMealRepository mealRepository, ListView listView, int index)
		{
			if (form.ShowForm() == true)
			{
				try
				{

					string mName = form.MealName;

					//double pAmount = form.Amount;

					listView.SelectedItems[0].Text = form.MealName;
					//listView.SelectedItems[0].SubItems[3].Text = form.Amount.ToString();

					mealRepository.EditMeal(mName, index);
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXCEPTION: " + ex.Message);
					throw;
				}
			}
		}

		public void DeleteMeal(IMealRepository mealRepository, ListView listView, int index)
		{
			foreach (ListViewItem item in listView.SelectedItems)
			{
				listView.Items.Remove(item);
			}

			mealRepository.DeleteMeal(index);
		}
	}
}
