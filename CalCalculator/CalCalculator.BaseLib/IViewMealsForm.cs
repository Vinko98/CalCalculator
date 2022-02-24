using System;
using CalCalculator.Model;
using CalCalculator.Model.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IViewMealsForm
    {
        void ViewMeals(List<Meal> meals, IMainFormController mainFormController, IMealRepository mealRepository);
    }
}
