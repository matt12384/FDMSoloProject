using ModelPoco;
using SoloProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectWcf
{
    public class UserService : IUserService
    {
        UsersRepository repository;

        public UserService()
        {
            repository = new UsersRepository();
        }

        public List<User> GetAllUsers()
        {
            return repository.GetAllUsers();
        }

        public User GetUserById(int userId)
        {
            return repository.GetUserById(userId);
        }

        public List<User> GetUserByString(string username)
        {
            return repository.GetUserByString(username);
        }

        public void AddUser(User user)
        {
            repository.AddUser(user);
        }

        public void EditUser(User user)
        {
            repository.EditUser(user);
        }

        public void EditPassword(User user)
        {
            repository.EditPassword(user);
        }

        public void RemoveUser(int userId)
        {
            repository.RemoveUser(userId);
        }

        public bool IsValid(string username, string password)
        {
            return repository.IsValid(username, password);
        }

        public bool IsAdmin(string username)
        {
            return repository.IsAdmin(username);
        }
    }
}
