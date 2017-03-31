using SoloProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoloProjectMvc.SoloProjectReference;

namespace SoloProjectMvc.Controllers
{
    public class UserController : Controller
    {
        UserServiceClient reference = new UserServiceClient();
        
        // GET: Index
        public ActionResult Index()
        {
            return View(reference.GetAllUsers());
        }

        // GET: Index/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Index/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Index/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                User user = new User();
                reference.AddUser(new SoloProjectReference.User()
                {
                    EmailAddress = Request.Form["EmailAddress"],
                    FirstName = Request.Form["Firstname"],
                    LastName = Request.Form["LastName"],
                    Password = Request.Form["Password"],
                    Username = Request.Form["Username"],
                });
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Index/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Index/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Index/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Index/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
