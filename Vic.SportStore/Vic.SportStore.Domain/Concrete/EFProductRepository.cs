using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportStore.Domain.Abstract;
using Vic.SportStore.Domain.Entities;

namespace Vic.SportStore.Domain.Concrete
{
    public class EFProductRepository : IProductsRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
