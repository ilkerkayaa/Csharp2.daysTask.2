using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 gb RAM", UnitInStock=10, UnitPrice=10000},
                new Product{ProductId=2, CategoryId=2, ProductName="Asus Laptop", QuantityPerUnit="16 gb RAM", UnitInStock=9, UnitPrice=8000},
                new Product{ProductId=3, CategoryId=3, ProductName="Hp Laptop", QuantityPerUnit="8 gb RAM", UnitInStock=3, UnitPrice=6000},
                new Product{ProductId=4, CategoryId=4, ProductName="Samsung Laptop", QuantityPerUnit="4 gb RAM", UnitInStock=4, UnitPrice=4000},
                new Product{ProductId=5, CategoryId=5, ProductName="Monster Laptop", QuantityPerUnit="4 gb RAM", UnitInStock=5, UnitPrice=3000}
            };


            Console.WriteLine("Algoritmik----------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock>3)
                {
                    Console.WriteLine(product.ProductName);
                }
                
            }

            Console.WriteLine("Linq----------------");

            var result = products.Where(product => product.UnitPrice > 5000 && product.UnitInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }


            GetProducts(products);

        }

        static List<Product> GetProducts(List<Product> products)
        {

            List<Product> filteredProducts = new List<Product>();


            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 5000 && product.UnitInStock > 3).ToList();
        }

            

    }



    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

    }


}
