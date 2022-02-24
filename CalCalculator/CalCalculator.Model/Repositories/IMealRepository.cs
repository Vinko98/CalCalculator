using System;
using System.Collections.Generic;
using CalCalculator.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model.Repositories
{
    public interface IMealRepository
    {
        Meal GetMealById(int mealId);
        Meal GetMealByName(string mealName);
        List<Meal> GetAllMeals();
        List<int> GetAllMealsIds();
        void AddMeal(Meal meal);
        void DeleteMeal(int index);
        List<string> GetAllMealsNames();
        double GetTotalMealEnergyByMealName(string mealName);
        List<string> GetAllProductNamesByMealName(string mealName);
        List<Product> GetAllProductsByMealName(string mealName);
        int GetMealIndexByName(string mealName);
        void EditMeal(string mealName, int index);

    }
}
