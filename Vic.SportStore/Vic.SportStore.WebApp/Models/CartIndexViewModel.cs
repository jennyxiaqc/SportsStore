using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vic.SportStore.Domain.Entities;

namespace Vic.SportStore.WebApp.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}