using CalCalculator.Model.Repositories;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.BaseLib
{
    public interface IWindowFormsFactory
    {
        IAddProductForm CreateAddProductForm(List<string> productTypes);
        IViewProductsForm CreateViewProductsForm();
        IEditProductForm CreateEditProductForm();
        IAddMealForm CreateAddMealForm(IProductRepository productRepository);
        IViewMealsForm CreateViewMealsForm(IMealRepository mealRepository);
        IEditMealForm CreateEditMealForm(ListView listView, IMealRepository mealRepository, IProductRepository productRepository);
        IAddUserForm CreateAddUserForm();
        IViewUsersForm CreateViewUsersForm();
        IEditUserForm CreateEditUserForm();
        IAddWorkoutForm CreateAddWorkoutForm();
        IViewWorkoutsForm CreateViewWorkoutsForm();
        IEditWorkoutForm CreateEditWorkoutForm();
        IAddEnergyIntakeForm CreateAddEnergyIntakeForm(IMealRepository mealRepository, IUserRepository userRepository);
        IAddEnergyConsumptionForm CreateAddEnergyConsumptionForm(IWorkoutRepository workoutRepository, IUserRepository userRepository);
        IViewEnergyExchangesForm CreateViewEnergyExchangesForm();
    }
}
