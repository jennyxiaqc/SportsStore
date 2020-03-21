using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportStore.Domain.Abstract;
using Vic.SportStore.WebApp.Models;

namespace Vic.SportStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 2;
        public IProductsRepository ProductsRepository { get; set; }   //Property inject

        // GET: Product
        //public ViewResult List()
        //{
        //    return View(ProductsRepository.Products);
        //}


        public ViewResult List(int page = 1)
        {
            //return View(
            //ProductsRepository
            //.Products
            //.OrderBy(p => p.ProductId)
            //.Skip((page - 1) * PageSize)
            //.Take(PageSize));
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = ProductsRepository
                .Products
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = ProductsRepository.Products.Count()
                }
            };
            return View(model);

        }
    }
}