using ModelPoco;
using SoloProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
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

        public void AddUser(User user)
        {
            repository.AddUser(user);
        }

        public void AddAddressToUser(int userId, Address address)
        {
            repository.AddAddressToUser(userId, address);
        }

        public void EditUsername(User user)
        {
            repository.EditUsername(user);
        }

        public void RemoveUser(int userId)
        {
            repository.RemoveUser(userId);
        }
    }
}
