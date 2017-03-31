using SoloProject;
using SoloProjectMvc.ProductReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoloProjectMvc.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminProductController : Controller
    {
        ProductServiceClient productServiceClient = new ProductServiceClient();
        SoloProjectEntities db = new SoloProjectEntities();

        public ActionResult AllProducts()
        {
            return View(productServiceClient.GetAllProducts());
        }

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
            return View(productServiceClient.GetProductById(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productServiceClient.AddProduct(product);
                    return RedirectToAction("AllProducts");
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(productServiceClient.GetProductById(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                // TODO: Add update logic here
                product.ProductId = id;
                productServiceClient.EditProduct(product);
                return RedirectToAction("AllProducts");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(productServiceClient.GetProductById(id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                // TODO: Add delete logic here
                productServiceClient.RemoveProduct(id);
                return RedirectToAction("AllProducts");
            }
            catch
            {
                return View();
            }
        }
    }
}
