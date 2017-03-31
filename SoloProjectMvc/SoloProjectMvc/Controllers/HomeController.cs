﻿using SoloProjectMvc.ProductReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoloProjectMvc.Controllers
{
    public class HomeController : Controller
    {
        ProductServiceClient productServiceClient = new ProductServiceClient();
        public ActionResult Index()
        {
            return View(productServiceClient.GetAllProducts());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}