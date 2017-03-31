using SoloProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoloProjectMvc.Controllers
{
    public class ProductManager
    {
        internal bool IsValid(string searchTerm)
        {
            using (var db = new SoloProjectEntities()) // use your DbConext
            {
                // if your users set name is Users
                return db.Products.Any(u => u.Name == searchTerm || u.Category == searchTerm);
            }
        }
    }
}