using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using SoloProjectMvc.UserReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace SoloProjectMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminUserController : Controller
    {
        UserServiceClient userServiceClient = new UserServiceClient();

        // GET: Admin
        public ActionResult AllUsers()
        {
            return View(userServiceClient.GetAllUsers());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View(userServiceClient.GetUserById(id));
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                userServiceClient.AddUser(user);
                return View("AllUsers");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View(userServiceClient.GetUserById(id));
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            try
            {
                user.UserId = id;
                userServiceClient.EditUser(user);
                return RedirectToAction("AllUsers");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View(userServiceClient.GetUserById(id));
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User user)
        {
            try
            {
                userServiceClient.RemoveUser(id);
                return RedirectToAction("AllUsers");
            }
            catch
            {
                return View();
            }
        }
    }
}
