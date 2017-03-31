using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProject
{
    public interface IUsersRepository
    {
        List<User> GetAllUsers();

        User GetUserById(int userId);

        List<User> GetUserByString(string username);

        void AddUser(User user);

        void EditUser(User user);

        void RemoveUser(int userId);

        bool IsValid(string emailAddress, string password);

        bool IsAdmin(string emailAddress);
    }
}
