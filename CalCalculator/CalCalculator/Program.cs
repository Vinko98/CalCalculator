using CalCalculator.PresentationLayer;
using CalCalculator.PresentationLayer.Factories;
using CalCalculator.Controllers;
using CalCalculator.MemoryBasedDAL;
using CalCalculator.Model.Repositories;
using CalCalculator.Model;

using CalCalculator.BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowFormsFactory formsFactory = new WindowFormsFactory();

            ProductRepository productRepository = new ProductRepository();

            MealRepository mealRepository = new MealRepository();

            UserRepository userRepository = new UserRepository();

            EnergyExchangeRepository energyExchangeRepository = new EnergyExchangeRepository();

            WorkoutRepository workoutRepository = new WorkoutRepository();

            MainFormController mainController = new MainFormController(formsFactory, productRepository, mealRepository, userRepository, energyExchangeRepository, workoutRepository);

            InitalizeProducts(productRepository, userRepository, mealRepository, workoutRepository);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(mainController));
        }

        public static void InitalizeProducts(IProductRepository productRepository, IUserRepository userRepository, IMealRepository mealRepository, IWorkoutRepository workoutRepository)
        {
            productRepository.AddProduct(new Food("Apple", 52));
            productRepository.AddProduct(new Food("Chicken breast", 110));
            productRepository.AddProduct(new Food("Rice", 368));
            productRepository.AddProduct(new Food("French fries", 270));
            productRepository.AddProduct(new Beverage("Coke", 39));
            productRepository.AddProduct(new Beverage("Apple juice", 46));

            userRepository.AddUser(new User(userRepository.GetNewUserId(),"Ivo", 180, 100, "Male", 30));

            List<Product> products = new List<Product>();
            Food cb = new Food("Chicken breast", 110);
            cb.Amount = 100;
            Food r = new Food("Rice", 368);
            r.Amount = 100;
            Beverage aj = new Beverage("Apple juice", 46);
            aj.Amount = 200;
            products.Add(cb);
            products.Add(r);
            products.Add(aj);
            mealRepository.AddMeal(new Meal(products, "Lunch"));

            workoutRepository.AddWorkout(new Workout(300, "Running", workoutRepository.GetNewWorkoutId()));


        }
    }
}
