using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportStore.Domain.Abstract;

namespace Vic.SportStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository ProductsReposotory { get; set; }   //Property inject

        // GET: Product
        public ViewResult List()
        {
            return View(ProductsReposotory.Products);
        }
    }
}