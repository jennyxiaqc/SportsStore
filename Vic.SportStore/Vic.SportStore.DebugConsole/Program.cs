using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportStore.Domain.Concrete;
using Vic.SportStore.Domain.Entities;

namespace Vic.SportStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext())
            {
                for (int i = 0; i < 10; i++)
                {
                var product = new Product() 
                { 
              
                    Name="p1",
                    Price=1.2m,
                    Description="des1",
                    Category="c1"
                };
                ctx.Products.Add(product);
                }
                ctx.SaveChanges();
                //ctx
                //    .Products
                 //   .ToList()
                 //   .ForEach(x => x.Name);
            }

            Console.WriteLine("Done");
            Console.ReadLine();

        }
    }
}
