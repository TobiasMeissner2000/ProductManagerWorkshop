using ProductManager.ProductManager;
using System;
using ProductManager.Models;

namespace WorkshopApi
{
    internal class Program
    {
        private static string authTokenTobias = "dcq817XiNUfUWz74E6fe9kINmNninZvEXoZIYHup";
        public static ProductManagerV1 ProductManagerV1 { get; set; } = new ProductManagerV1(authTokenTobias);
        public static ProductManagerV2 ProductManagerV2 { get; set; } = new ProductManagerV2(authTokenTobias);
        public static Product TestProduct = new Product()
        {
            Name = "TobisSupaaDupaaProduct",
            Price = 1499.99
        };
        private static void Main(string[] args)
        {
            Console.WriteLine("--- Start ---");

            TestMethod();

            Console.WriteLine("--- End ----");
        }

        public static async void TestMethod()
        {
            
            var allProducts = ProductManagerV1.GetAllProductsAsync();
            
            var end = "hello";
        }
    }
}