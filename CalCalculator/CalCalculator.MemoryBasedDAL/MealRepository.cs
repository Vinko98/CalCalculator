using CalCalculator.Model;
using CalCalculator.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.MemoryBasedDAL
{
    public class MealRepository : IMealRepository
    {
        private static int id = 1;
        private readonly List<Meal> meals = new List<Meal>();

        public int GetNewMealId()
        {
            int nextId = id;
            id++;
            return nextId;
        }

        public Meal GetMealById(int mealId)
        {
            var meal = (from l in meals where l.Id == mealId select l).First();
            return meal;
        }

        public Meal GetMealByName(string mealName)
        {
            var meal = (from l in meals where l.Name == mealName select l).First();

            if (meal != null)
                return meal;

            throw new MealDoesntExist();
        }

        public List<Meal> GetAllMeals()
        {
            return meals;
        }

        public List<int> GetAllMealsIds()
        {
            return meals.Select(meal => meal.Id).ToList();
        }

        public List<string> GetAllMealsNames()
        {
            return meals.Select(a => a.Name).ToList();
        }

        public List<string> GetAllProductNamesByMealName(string mealName)
        {
            List<Product> products = (from l in meals where l.Name == mealName select l.ProductsInMeal).First();
            return products.Select(a => a.Name).ToList();
        }

        public List<Product> GetAllProductsByMealName(string mealName)
        {
            return (from l in meals where l.Name == mealName select l.ProductsInMeal).First();
        }

        public double GetTotalMealEnergyByMealName(string mealName)
        {
            return (from l in meals where l.Name == mealName select l.EnergyValue).First();
        }

        public void AddMeal(Meal newMeal)
        {
            if (meals.Any(meal => meal.Name == newMeal.Name))
            {
                throw new MealAlreadyExists();
            }
            else
            {
                if (newMeal.Id == Meal.UndefinedMealID || meals.Any(acc => acc.Id == newMeal.Id))
                    newMeal.Id = GetNewMealId();
                meals.Add(newMeal);
            }
        }

        public int GetMealIndexByName(string mealName)
        {
            var meal = (from l in meals where l.Name == mealName select l).First();
            if (meal != null)
            {
                return meals.IndexOf(meal);
            }
            throw new MealDoesntExist();
        }

        public void DeleteMeal(int index)
        {
            meals.RemoveAt(index);
        }

        public void EditMeal(string mealName, int index)
        {
            meals[index].Name = mealName;
        }

    }
}
