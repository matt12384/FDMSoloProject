using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoloProjectMvc.UserReference;
using SoloProject;
using System.Security.Claims;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using System.Data.Entity.SqlServer;
using SoloProjectMvc.AddressReference;


namespace SoloProjectMvc.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UserServiceClient userServiceClient = new UserServiceClient();
        SoloProjectEntities db = new SoloProjectEntities();
        AddressServiceClient addressServiceClient = new AddressServiceClient();

        // GET: User
        public ActionResult Index()
        {
            return View(userServiceClient.GetAllUsers());
        }

        public ActionResult Details(string username)
        {
            username = User.Identity.GetUserName();
            userServiceClient.GetUserByString(username);
            return View(userServiceClient.GetUserByString(username));
        }

        // GET: User/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Create(SoloProjectMvc.UserReference.User user)
        {
                userServiceClient.AddUser(user);
                string username = Request.Form["EmailAddress"];

                var ident = new ClaimsIdentity(
                  new[] { 
                  new Claim(ClaimTypes.NameIdentifier, username),
                  new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "ASP.NET Identity", "http://www.w3.org/2001/XMLSchema#string"),

                  new Claim(ClaimTypes.Name, username),
                },
                  DefaultAuthenticationTypes.ApplicationCookie);

                HttpContext.GetOwinContext().Authentication.SignIn(
                   new AuthenticationProperties { IsPersistent = false }, ident);
                return RedirectToAction("Index", "Home");
        }

        // GET: User/Edit/5
        
        public ActionResult Edit(int id)
        {
            return View(userServiceClient.GetUserById(id));
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SoloProjectMvc.UserReference.User user)
        {
            try
            {
                user.UserId = id;
                userServiceClient.EditUser(user);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View(userServiceClient.GetUserById(id));
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SoloProjectMvc.UserReference.User user)
        {
            try
            {
                userServiceClient.RemoveUser(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ChangePassword(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult ChangePassword(int id, SoloProjectMvc.UserReference.User user)
        {
            try
            {
                user.UserId = id;
                userServiceClient.EditPassword(user);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Create
        public ActionResult Address()
        {
            return View();
        }

        // POST: Address/Create
        [HttpPost]
        public ActionResult Address(int id, SoloProjectMvc.AddressReference.Address address)
        {
            try
            {
                // TODO: Add insert logic here
                address.UserId = id;
                this.addressServiceClient.AddAddressToUser(id, address);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
