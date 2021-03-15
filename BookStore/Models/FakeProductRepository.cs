using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class FakeProductRepository /*: IProductRepository*/
    {
        public IQueryable<Product> Products => new List<Product> {
             new Product { Name = "Introduction to computer science", Price = 50 },
             new Product { Name = "Introducion to Software Programming", Price = 60 },
             new Product { Name = "Introduction to data structure", Price = 120 }
        }.AsQueryable<Product>();
    }
}
