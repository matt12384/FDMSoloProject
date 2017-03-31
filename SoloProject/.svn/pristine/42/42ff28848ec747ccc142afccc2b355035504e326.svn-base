using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    [ServiceContract]
    interface IUserService
    {
        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract]
        User GetUserById(int userId);

        //User GetUserByUsername(string username);

        [OperationContract]
        void AddUser(User user);

        [OperationContract]
        void AddAddressToUser(int userId, Address address);

        [OperationContract]
        void EditUsername(User user);

        [OperationContract]
        void RemoveUser(int userId);
    }
}
