using ClothBazar.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class ProductsController : Controller
    {
        //DEPENDENCY INJECTION
        //====================
        //IF we have dependency on any object - pass it as a paramenter to constructor 
        //Instead of creating a new instance using new keyword
        //To use Dependency Injection in .net => Unity.MVC5 Package
        //Set service configuration in UnityConfig.cs in App_Start + use in Global.asax

        //Create ProductService instance 
        //--------------------------------
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
    }
}