using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    public class User : Energy
    {
        public User(int id, string name, double height, double weight, string gender, int age)
            : base(0, name, id)
        {
            energyExchanges = new List<EnergyExchange>();
            Height = height;
            Weight = weight;
            Gender = gender;
            Age = age;
        }

        public double CalculateBMR(double height, double weight, string gender, int age)
        {
            double BMR = 0;
            switch (gender)
            {
                case "male":
                    BMR = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age);
                    break;
                case "female":
                    BMR = 447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age);
                    break;
                default:
                    break;
            }
            return BMR;
        }

        public double Height { get; set; }
        public double Weight { get; set; }
        public double EnergyValuee { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public List<EnergyExchange> energyExchanges { get; set; }
    }
}
