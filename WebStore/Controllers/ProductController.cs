using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Products> Products = new List<Products>()
            {

            };
            return View(Products);
        }
        public ActionResult Edit(int? selects)
        {
            var id = Request.QueryString["id"];

            var getId = Request[id];// Can also be the string name for the input name

            return View();
        }
    }
}