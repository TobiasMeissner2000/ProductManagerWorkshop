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
            Name = "CoolesDingDasJederBraucht",
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
            var a = ProductManagerV2.GetAllReviews("101");
            var allProducts = ProductManagerV2.GetReviewById("1", "101");
        }
    }
}