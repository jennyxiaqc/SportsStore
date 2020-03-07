using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SuperStore.Domain.Abstract;

namespace Vic.SportStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository ProductsReposotory { get; set; }   //Property zhu RU

        // GET: Product
        public ViewResult List()
        {
            return View(ProductsReposotory.Products);
        }
    }
}