using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportStore.Domain.Abstract;
using Vic.SportStore.Domain.Entities;

namespace Vic.SportStore.Domain.Concrete
{
    public class InMemoryProductsRepository : IProductsRepository
    {
        private List<Product> _products = new List<Product> 
        {
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Surf board", Price = 179 },
            new Product { Name = "Running shoes", Price = 95 }
        };
        public IEnumerable<Product> Products
        {
            get { return _products; }
        }
    }
}
