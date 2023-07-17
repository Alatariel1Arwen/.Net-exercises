using System;
using System.Collections.Generic;
using System.Linq;
using Join;

namespace LinqJoinExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { ProductId = 1, Name = "Product 1", CategoryId = 1 },
                new Product { ProductId = 2, Name = "Product 2", CategoryId = 2 },
                new Product { ProductId = 3, Name = "Product 3", CategoryId = 1 },
                new Product { ProductId = 4, Name = "Product 4", CategoryId = 3 },
            };

            List<Category> categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "Category 1" },
                new Category { CategoryId = 2, Name = "Category 2" },
                new Category { CategoryId = 3, Name = "Category 3" },
            };

            var joinedList = from product in products
                             join category in categories on product.CategoryId equals category.CategoryId
                             select new ProductCategory
                             {
                                 ProductName = product.Name,
                                 CategoryName = category.Name
                             };

            foreach (var item in joinedList)
            {
                Console.WriteLine($"Product: {item.ProductName}, Category: {item.CategoryName}");
            }

            Console.ReadLine();
        }
    }
}