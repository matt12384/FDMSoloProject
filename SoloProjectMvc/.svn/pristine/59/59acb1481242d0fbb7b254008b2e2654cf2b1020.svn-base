using SoloProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloProjectMvc.Controllers
{
    class UserManager
    {
        internal bool IsValid(string username, string password)
        {
            using (var db = new SoloProjectEntities())
            {
                return db.Users.Any(u => u.EmailAddress == username && u.Password == password);
            }
        }

        internal bool IsAdmin(string username)
        {
            using (var db = new SoloProjectEntities())
            {
                return db.Users.Any(u => u.EmailAddress == username && u.AccountType == "Admin");
            }
        }
    }
}
