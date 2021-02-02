using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,ProductName="Msi Laptop",QuantitiyPerUnit="2",UnitPrice=12000,UnitStock=1},
                new Product{ProductId=2,ProductName="Asus Laptop",QuantitiyPerUnit="3",UnitPrice=5000,UnitStock=1},
                new Product{ProductId=3,ProductName="Monster Laptop",QuantitiyPerUnit="5",UnitPrice=8000,UnitStock=1},
                new Product{ProductId=4,ProductName="Hp Laptop",QuantitiyPerUnit="1",UnitPrice=7000,UnitStock=1}
            };

            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"}
            };

            //foreach (var i in products)
            //{
            //    if (i.UnitPrice >= 7000)  !! Linq kullanılmasaydı döngü bu şekilde oluşturulacaktı. !!
            //    {
            //        Console.WriteLine(i.ProductName);
            //    }
                
            //}
            // Linq kullanarak products listesinin içine i değişkeni ile girip geziyorum.
            // Unit price 7000 den fazla ve unitstock 1 e eşit olanları şarta bağlıyorum.
            // Foreach döngüsü ile şartı sağlayanların productId sini yazdırıyorum.
            var result = products.Where(i => i.UnitPrice > 7000 && i.UnitStock == 1); // burda var== List<Product> türünde bir result görmesini sağlar.
            foreach (var i in products)
            {
                Console.WriteLine(i.ProductId);
            }

            // Kategori ıd si 1 olan şartı koyuldu.
            // Döngü ile şarta uygun olanların kategori ismi yazdırıldı.
            var result2 = categories.Where(c => c.CategoryId == 1);
            foreach (var c in categories)
            {
                Console.WriteLine(c.CategoryName);
            }


            // Belirli şartları yerine getiren ve ürün isimlerini yazdıran metod tanımlanır.
            static List<Product> GetProducts(List<Product> products) 
        
            {
                return products.Where(i => i.UnitPrice > 7000 && i.UnitStock == 1).ToList();
                foreach (var i in products)
                {
                    Console.WriteLine(i.ProductName);

                }

                        
            };

            

        }
    }






    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantitiyPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
