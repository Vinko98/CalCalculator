using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IMainFormController
    {
        void AddProduct();
        void ViewProducts();
        void EditProduct(ListView listView);
        void DeleteProduct(ListView listView);
        void AddMeal();
        void ViewMeals();
        void EditMeal(ListView listView);
        void DeleteMeal(ListView listView);
        void AddUser();
        void ViewUsers();
        void EditUser(ListView listView);
        void DeleteUser(ListView listView);
        void AddWorkout();
        void ViewWorkouts();
        void EditWorkout(ListView listView);
        void DeleteWorkout(ListView listView);
        void AddEnergyIntake();
        void AddEnergyConsumption();
        void ViewEnergyExchanges();
    }
}
