using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportStore.Domain.Abstract;
using Vic.SportStore.Domain.Entities;
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


        public ViewResult List(string category, int page = 1)
        {
            //return View(
            //ProductsRepository
            //.Products
            //.OrderBy(p => p.ProductId)
            //.Skip((page - 1) * PageSize)
            //.Take(PageSize));
            ProductsListViewModel model = new ProductsListViewModel
            {
                CurrentCategory = category,
                Products = ProductsRepository
                .Products
                .OrderBy(p => p.ProductId)
                .Where(p => category == null || p.Category == category)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = ProductsRepository.Products.
                    Where(p => category == null || p.Category == category).Count()
                }
            };
            return View(model);

        }

        public FileContentResult GetImage(int productId)
        {
            Product prod = ProductsRepository
            .Products
            .FirstOrDefault(p => p.ProductId == productId);
            if (prod != null)
            {
                return File(prod.ImageData, prod.ImageMimeType);
            }
            else
            {
                return null;
            }
        }
    }
}