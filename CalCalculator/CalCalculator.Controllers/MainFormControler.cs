using CalCalculator.BaseLib;
using CalCalculator.Model.Repositories;
using System.Windows.Forms;
using CalCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Controllers
{
    public class MainFormController : IMainFormController
    {

        private readonly IWindowFormsFactory formsFactory = null;
        private readonly IProductRepository productRepository = null;
        private readonly IMealRepository mealRepository = null;
        private readonly IUserRepository userRepository = null;
        private readonly IEnergyExchangeRepository energyExchangeRepository = null;
        private readonly IWorkoutRepository workoutRepository = null;


        public MainFormController(IWindowFormsFactory formsFactory, IProductRepository productRepository, IMealRepository mealRepository, IUserRepository userRepository, IEnergyExchangeRepository energyExchangeRepository, IWorkoutRepository workoutRepository)
        {
            this.formsFactory = formsFactory;
            this.productRepository = productRepository;
            this.mealRepository = mealRepository;
            this.userRepository = userRepository;
            this.energyExchangeRepository = energyExchangeRepository;
            this.workoutRepository = workoutRepository;
        }

        //private Form activeForm = null;
        //private void OpenNewFormInPanel(Object newForm, Panel panelNewForm)
        //{
        //    var newForm1 = newForm as Form;
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = newForm1;
        //    //newForm1.TopLevel = false;
        //    newForm1.FormBorderStyle = FormBorderStyle.None;
        //    newForm1.Dock = DockStyle.Fill;
        //    panelNewForm.Controls.Add(newForm1);
        //    panelNewForm.Tag = newForm;
        //    newForm1.BringToFront();
        //    //newForm1.Show();
        //}

        public void AddProduct()
        {

            var form = formsFactory.CreateAddProductForm(ProductTypes.getProductTypesList());
            //OpenNewFormInPanel(form, panelNewForm);

            var productController = new ProductController();
            productController.AddProduct(form, productRepository);

        }

        public void ViewProducts()
        {
            var form = formsFactory.CreateViewProductsForm();

            var productController = new ProductController();
            productController.ViewProducts(form, productRepository, this);
        }

        public void EditProduct(ListView listView)
        {
            var form = formsFactory.CreateEditProductForm();

            var productController = new ProductController();
            int index = productRepository.GetProductIndexByName(listView.SelectedItems[0].SubItems[1].Text);
            productController.EditProduct(form, productRepository, listView, index);
        }

        public void DeleteProduct(ListView listView)
        {
            var productController = new ProductController();
            int index = productRepository.GetProductIndexByName(listView.SelectedItems[0].SubItems[1].Text);
            productController.DeleteProduct(productRepository, listView, index);
        }

        public void AddMeal()
        {
            var form = formsFactory.CreateAddMealForm(productRepository);

            var mealController = new MealController();
            
            mealController.AddMeal(form, mealRepository);
        }

        public void ViewMeals()
        {
            var form = formsFactory.CreateViewMealsForm(mealRepository);

            var mealController = new MealController();
            mealController.ViewMeals(form, mealRepository, this);
        }

        public void EditMeal(ListView listView)
        {
            var form = formsFactory.CreateEditMealForm(listView, mealRepository, productRepository);

            var mealController = new MealController();
            int index = mealRepository.GetMealIndexByName(listView.SelectedItems[0].Text);
            mealController.EditMeal(form, mealRepository, listView, index);
        }

        public void DeleteMeal(ListView listView)
        {
            var mealController = new MealController();
            int index = mealRepository.GetMealIndexByName(listView.SelectedItems[0].Text);
            mealController.DeleteMeal(mealRepository, listView, index);
        }

        public void AddUser()
        {

            var form = formsFactory.CreateAddUserForm();
            //OpenNewFormInPanel(form, panelNewForm);

            var userController = new UserController();
            userController.AddUser(form, userRepository);

        }
        public void ViewUsers()
        {
            var form = formsFactory.CreateViewUsersForm();

            var userController = new UserController();
            userController.ViewUsers(form, userRepository, this);
        }

        public void EditUser(ListView listView)
        {
            var form = formsFactory.CreateEditUserForm();

            var userController = new UserController();
            int index = userRepository.GetUserIndexByName(listView.SelectedItems[0].Text);
            userController.EditUser(form, userRepository, listView, index);
        }

        public void DeleteUser(ListView listView)
        {
            var userController = new UserController();
            int index = userRepository.GetUserIndexByName(listView.SelectedItems[0].Text);
            userController.DeleteUser(userRepository, listView, index);
        }

        public void AddWorkout()
        {

            var form = formsFactory.CreateAddWorkoutForm();
            //OpenNewFormInPanel(form, panelNewForm);

            var workoutController = new WorkoutController();
            workoutController.AddWorkout(form, workoutRepository);

        }
        public void ViewWorkouts()
        {
            var form = formsFactory.CreateViewWorkoutsForm();

            var workoutController = new WorkoutController();
            workoutController.ViewWorkouts(form, workoutRepository, this);
        }

        public void EditWorkout(ListView listView)
        {
            var form = formsFactory.CreateEditWorkoutForm();

            var workoutController = new WorkoutController();
            int index = workoutRepository.GetWorkoutIndexByName(listView.SelectedItems[0].Text);
            workoutController.EditWorkout(form, workoutRepository, listView, index);
        }

        public void DeleteWorkout(ListView listView)
        {
            var workoutController = new WorkoutController();
            int index = workoutRepository.GetWorkoutIndexByName(listView.SelectedItems[0].Text);
            workoutController.DeleteWorkout(workoutRepository, listView, index);
        }

        public void AddEnergyIntake()
        {

            var form = formsFactory.CreateAddEnergyIntakeForm(mealRepository, userRepository);
            //OpenNewFormInPanel(form, panelNewForm);

            var energyExchangeController = new EnergyExchangeController();
            energyExchangeController.AddEnergyIntake(form, energyExchangeRepository, userRepository);

        }
        public void AddEnergyConsumption()
        {

            var form = formsFactory.CreateAddEnergyConsumptionForm(workoutRepository, userRepository);
            //OpenNewFormInPanel(form, panelNewForm);

            var energyExchangeController = new EnergyExchangeController();
            energyExchangeController.AddEnergyConsumption(form, energyExchangeRepository, userRepository);

        }
        public void ViewEnergyExchanges()
        {
            var form = formsFactory.CreateViewEnergyExchangesForm();

            var energyExchangeController = new EnergyExchangeController();
            energyExchangeController.ViewEnergyExchanges(form, energyExchangeRepository);
        }

    }
}
