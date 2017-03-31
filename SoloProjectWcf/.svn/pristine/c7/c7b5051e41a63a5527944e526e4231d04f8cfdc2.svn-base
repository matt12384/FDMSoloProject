using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectWcf
{
    [ServiceContract]
    interface IUserService
    {
        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract]
        User GetUserById(int userId);

        [OperationContract]
        List<User> GetUserByString(string username);

        [OperationContract]
        void AddUser(User user);

        [OperationContract]
        void EditUser(User user);

        [OperationContract]
        void EditPassword(User user);

        [OperationContract]
        void RemoveUser(int userId);

        [OperationContract]
        bool IsValid(string username, string password);

        [OperationContract]
        bool IsAdmin(string username);
    }
}
