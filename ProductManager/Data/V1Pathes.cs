namespace ProductManager.Data
{
    public static class V1Pathes
    {
        public static string GetAllProducts { get; } = "/api/v1/product/getall";
        public static string GetProduct { get; } = "/api/v1/product/{0}/get";
        public static string AddProduct { get; } = "/api/v1/product/add";
        public static string EditProduct { get; } = "/api/v1/product/edit";
        public static string DeleteProduct { get; } = "/api/v1/product/{0}/remove";
    }
}