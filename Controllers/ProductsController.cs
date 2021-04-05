using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emarket.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products
        public ActionResult ProductDetails(int productId)
        {
            // return View(DBmanager.GetProductDetailsBy(productId));
            return View();
        }

        // GET: Products
        public ActionResult CategoryProducts(int categoryId)
        {
            // return view(DBmanager.GetCategoryProductsBy(categoryId));
            return View();
        }

        // GET: Products
        public ActionResult MacrocategoryProducts(int macrocategoryId)
        {
            // return view(DBmanager.GetMacrocategoryProductsBy(macrocategoryId))
            return View();
        }
    }
}