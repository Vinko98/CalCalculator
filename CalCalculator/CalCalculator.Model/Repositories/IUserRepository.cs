using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model.Repositories
{
    public interface IUserRepository
    {
        int GetNewUserId();
        User GetUserById(int userId);
        User GetUserByName(string userName);
        List<User> GetAllUsers();
        List<int> GetAllUsersIds();
        void AddUser(User user);
        void DeleteUser(int index);
        int GetUserIndexByName(string userName);
        void EditUser(string name, double height, double weight, string gender, int age, int index);
        List<string> GetAllUsersNames();
        void UpdateUserByName(string userName, double energyValue, EnergyExchange energyExchange);
    }
}
