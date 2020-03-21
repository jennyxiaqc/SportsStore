﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vic.SportStore.Domain.Entities;

namespace Vic.SportStore.WebApp.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}