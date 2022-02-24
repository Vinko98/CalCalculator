using CalCalculator.Model;
using CalCalculator.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.MemoryBasedDAL
{
    public class UserRepository : IUserRepository
    {

        private static int id = 1;
        private readonly List<User> users = new List<User>();

        public int GetNewUserId()
        {
            int nextId = id;
            id++;
            return nextId;
        }

        public User GetUserById(int userId)
        {
            var user = (from l in users where l.Id == userId select l).First();
            return user;
        }

        public User GetUserByName(string userName)
        {
            var user = (from l in users where l.Name == userName select l).First();

            if (user != null)
                return user;

            throw new UserDoesntExist();
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public List<int> GetAllUsersIds()
        {
            return users.Select(user => user.Id).ToList();
        }

        public void AddUser(User newUser)
        {
            if (users.Any(user => user.Name == newUser.Name))
            {
                throw new UserAlreadyExists();
            }
            else
            {
                users.Add(newUser);
            }
        }
        public int GetUserIndexByName(string userName)
        {
            var user = (from l in users where l.Name == userName select l).First();
            if (user != null)
            {
                return users.IndexOf(user);
            }
            throw new UserDoesntExist();
        }

        public List<string> GetAllUsersNames()
        {
            return users.Select(a => a.Name).ToList();
        }

        public void UpdateUserByName(string userName, double energyValue, EnergyExchange energyExchange)
        {
            int index = GetUserIndexByName(userName);
            users[index].EnergyValue += energyValue;
            users[index].energyExchanges.Add(energyExchange);
        }

        public void EditUser(string name, double height, double weight, string gender, int age, int index)
        {
            users[index].Name = name;
            users[index].Height = height;
            users[index].Weight = weight;
            users[index].Gender = gender;
            users[index].Age = age;
        }
        public void DeleteUser(int index)
        {
            users.RemoveAt(index);
        }
    }
}
