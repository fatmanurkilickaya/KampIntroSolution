using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add()
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 10;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Bilgisayar",
                UnitsInStock = 10
            };

            Product product3 = new Product{Id = 5,CategoryId = 2, ProductName = "Kalem", UnitsInStock = 10};
        }
    }
}
