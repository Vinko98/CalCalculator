using CalCalculator.BaseLib;
using CalCalculator.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.PresentationLayer.Factories
{
    public class WindowFormsFactory : IWindowFormsFactory
    {
        public IAddProductForm CreateAddProductForm(List<string> productTypes)
        {
            var form = new AddProductForm(productTypes);
            return form;
        }

        public IViewProductsForm CreateViewProductsForm()
        {
            var form = new ViewProductsForm();
            return form;
        }

        public IEditProductForm CreateEditProductForm()
        {
            var form = new EditProductForm();
            return form;
        }

        public IAddMealForm CreateAddMealForm(IProductRepository productRepository)
        {
            var form = new AddMealForm(productRepository);
            return form;
        }

        public IViewMealsForm CreateViewMealsForm(IMealRepository mealRepository)
        {
            var form = new ViewMealsForm();
            return form;
        }

        public IEditMealForm CreateEditMealForm(ListView listview, IMealRepository mealRepository, IProductRepository productRepository)
        {
            var form = new EditMealForm(listview, mealRepository, productRepository);
            return form;
        }

        public IAddUserForm CreateAddUserForm()
        {
            var form = new AddUserForm();
            return form;
        }

        public IViewUsersForm CreateViewUsersForm()
        {
            var form = new ViewUsersForm();
            return form;
        }

        public IEditUserForm CreateEditUserForm()
        {
            var form = new EditUserForm();
            return form;
        }

        public IAddWorkoutForm CreateAddWorkoutForm()
        {
            var form = new AddWorkoutForm();
            return form;
        }

        public IViewWorkoutsForm CreateViewWorkoutsForm()
        {
            var form = new ViewWorkoutsForm();
            return form;
        }
        public IEditWorkoutForm CreateEditWorkoutForm()
        {
            var form = new EditWorkoutForm();
            return form;
        }

        public IAddEnergyIntakeForm CreateAddEnergyIntakeForm(IMealRepository mealRepository, IUserRepository userRepository)
        {
            var form = new AddEnergyIntakeForm(mealRepository, userRepository);
            return form;
        }
        public IAddEnergyConsumptionForm CreateAddEnergyConsumptionForm(IWorkoutRepository workoutRepository, IUserRepository userRepository)
        {
            var form = new AddEnergyConsumptionForm(workoutRepository, userRepository);
            return form;
        }

        public IViewEnergyExchangesForm CreateViewEnergyExchangesForm()
        {
            var form = new ViewEnergyExchangesForm();
            return form;
        }
    }
}
