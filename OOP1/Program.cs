using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //İçinde özellik barındıran ve içinde metot barındıran 2 şekle ayrılır
            Product product1 = new Product();
            //normalde kullanıcıdan girmesini isteriz.
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnıtPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnıtPrice = 35
            };//PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
