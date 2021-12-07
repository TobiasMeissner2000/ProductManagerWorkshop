namespace ProductManager.Data
{
    public static class V2Pathes
    {
        public static string GetAllProducts { get; } = "/api/v2/product/getall";
        public static string GetProduct { get; } = "/api/v2/product/{0}/get";
        public static string AddProduct { get; } = "/api/v2/product/add";
        public static string EditProduct { get; } = "/api/v2/product/edit";
        public static string DeleteProduct { get; } = "/api/v2/product/{0}/remove";
        public static string Authenticate { get; } = "/api/v2/authenticate";
        public static string GetAllProductsReview { get; } = "/api/v2/product/{0}/review/getall";
        public static string GetProductReview { get; } = "/api/v2/product/{0}/review/{1}/get";
        public static string AddProductReview { get; } = "/api/v2/product/{0}/review/add";
        public static string EditProductReview { get; } = "/api/v2/product/{0}/review/{1}/edit";
    }
}