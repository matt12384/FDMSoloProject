using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoloProjectMvc.ProductReference;
using SoloProject;
using SoloProjectMvc.BasketItemsReference;
using SoloProjectMvc.BasketReference;
using SoloProjectMvc.UserReference;
using System.Security.Principal;
using System.Security.Claims;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using System.Data.Entity.SqlServer;

namespace SoloProjectMvc.Controllers
{
    public class ProductController : Controller
    {
        ProductServiceClient productServiceClient = new ProductServiceClient();
        UserServiceClient userServiceClient = new UserServiceClient();
        SoloProjectEntities db = new SoloProjectEntities();
        BasketItemsServiceClient basketItemsServiceClient = new BasketItemsServiceClient();
        

        public ActionResult Index(string searchString)
        {
            if (!productServiceClient.GetProductByString(searchString).Any() || String.IsNullOrEmpty(searchString))
            {
                return RedirectToAction("NoResults");
            }
            else
                return View(productServiceClient.GetProductByString(searchString));
        }

        public ActionResult NoResults(string searchString)
        {
            if (!productServiceClient.GetProductByString(searchString).Any() || String.IsNullOrEmpty(searchString))
            {
                return View();
            }
            else
                return View(productServiceClient.GetProductByString(searchString));
        }

        public ActionResult Search(string searchString)
        {
            if (!productServiceClient.GetProductByString(searchString).Any() || String.IsNullOrEmpty(searchString))
            {
                return View();
            }
            else
                return View(productServiceClient.GetProductByString(searchString));
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            TempData["productId"] = id;
            return View(productServiceClient.GetProductById(id));
        }

        public ActionResult AddToBasket()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddToBasket(SoloProjectMvc.BasketItemsReference.BasketItem basketItem)
        {
            string username = User.Identity.GetUserName();

            SoloProjectMvc.UserReference.User[] userArray = userServiceClient.GetUserByString(username);

            foreach (SoloProjectMvc.UserReference.User item in userArray)
            {
                int userId = item.UserId;
                int productId = Convert.ToInt32(TempData["productId"]);
                IQueryable<ModelPoco.Basket> basket = null;

                basket = (db.Baskets.Where(s => s.UserId.Equals(userId)));
                List<ModelPoco.Basket> basketList = basket.ToList();
                ModelPoco.Basket basketObject = basketList.Last();
                int basketId = basketObject.BasketId;

                basketItemsServiceClient.PopulateBasketAndProductKeys(basketId, productId, basketItem);

                Session["basketId"] = basketId;
            }
            return View();
        }

        public List<SoloProjectMvc.ProductReference.Product> GetProductsInCurrentBasket()
        {
            int id = Convert.ToInt32(Session["basketId"]);

            IQueryable<ModelPoco.BasketItem> basket = null;

            basket = (db.BasketItems.Where(s => s.BasketId.Equals(id)));

            List<SoloProjectMvc.ProductReference.Product> product = new List<SoloProjectMvc.ProductReference.Product>();

            foreach (ModelPoco.BasketItem item in basket)
            {
                product.Add(productServiceClient.GetProductById(item.ProductId));
            }
            return product;
        }

        public ActionResult Basket()
        {
            return View(GetProductsInCurrentBasket());
        }
    }
}
