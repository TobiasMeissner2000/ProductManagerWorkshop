namespace ProductManager.Data
{
    public class V2Pathes
    {
        public string GetAllProducts { get; } = "/api/v2/product/getall";
        public string GetProduct { get; } = $"/api/v2/product/{0}/get";
        public string AddProduct { get; } = "/api/v2/product/add";
        public string EditProduct { get; } = "/api/v2/product/edit";
        public string DeleteProduct { get; } = $"/api/v2/product/{0}/remove";
        public string Authenticate { get; } = "/api/v2/authenticate";
        public string GetAllProductsReview { get; } = $"/api/v2/product/{0}/review/getall";
        public string GetProductReview { get; } = $"/api/v2/product/{0}/review/{1}/get";
        public string AddProductReview { get; } = $"/api/v2/product/{0}/review/add";
        public string EditProductReview { get; } = $"/api/v2/product/{0}/review/{1}/edit";
    }
}
