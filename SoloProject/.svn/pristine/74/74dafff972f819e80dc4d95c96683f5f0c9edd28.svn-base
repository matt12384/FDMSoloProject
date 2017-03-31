
using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProject
{
    public class UsersRepository : IUsersRepository
    {
        SoloProjectEntities context;

        public UsersRepository()
        {
            context = new SoloProjectEntities();
        }

        public UsersRepository(SoloProjectEntities projectEntities)
        {
            this.context = projectEntities;
        }

        public List<User> GetAllUsers()
        {
            List<User> usersFromDatabase = new List<User>();

            if (context.Users != null)
            {
                foreach (User user in context.Users)
                {
                    usersFromDatabase.Add(user);
                }
            }
            return usersFromDatabase;
        }

        public User GetUserById(int userId)
        {
            User user = null;

            user = context.Users.Find(userId);

            return user;
        }

        public List<User> GetUserByString(string username)
        {
            IQueryable<User> user = null;

            user = (context.Users.Where(s => s.EmailAddress.Contains(username)));
            List<User> list = user.ToList();
            //User user2 = list.Last();
            return list;
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);

            context.SaveChanges();
        }

        public void EditUser(User user)
        {
            User userToUpdate = context.Users.Find(user.UserId);

            if (userToUpdate != null)
            {
                userToUpdate.FirstName = user.FirstName;
                userToUpdate.LastName = user.LastName;
                userToUpdate.EmailAddress = user.EmailAddress;
                userToUpdate.RetypeEmailAddress = user.RetypeEmailAddress;
            }

            context.SaveChanges();
        }

        public void EditPassword(User user)
        {
            User userToUpdate = context.Users.Find(user.UserId);

            if (userToUpdate != null)
            {
                userToUpdate.Password = user.Password;
                userToUpdate.RetypePassword = user.RetypePassword;
            }

            context.SaveChanges();
        }

        public void RemoveUser(int userId)
        {
            User user = context.Users.Find(userId);

            context.Users.Remove(user);

            context.SaveChanges();
        }

        public bool IsValid(string emailAddress, string password)
        {
            

            using (var db = new SoloProjectEntities())
            {
                IQueryable<User> user = db.Users.Where(u => u.EmailAddress == emailAddress);

                string passwordInDatabase = user.ToList().First().Password;
                if (passwordInDatabase == password)
                {
                    return db.Users.Any(u => u.EmailAddress == emailAddress && passwordInDatabase == password);
                }
                else return false;
                
            }
        }

        public bool IsAdmin(string emailAddress)
        {
            using (var db = new SoloProjectEntities())
            {
                return db.Users.Any(u => u.EmailAddress == emailAddress && u.AccountType == "Admin");
            }
        }
    }
}
