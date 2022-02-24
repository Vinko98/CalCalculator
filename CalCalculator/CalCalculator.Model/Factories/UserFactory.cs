using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model.Factories
{
    public class UserFactory
    {
        public static User CreateUser(string name, double height, double weight, string gender, int age, int id)
        {
            return new User(id, name, height, weight, gender, age);
        }
    }
}
