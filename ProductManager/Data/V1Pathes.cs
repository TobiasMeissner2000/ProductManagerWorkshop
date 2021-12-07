namespace ProductManager.Data
{
    public class V1Pathes
    {
        public string GetAllProducts { get; } = "/api/v1/product/getall";
        public string GetProduct { get; } = "/api/v1/product/{0}/get";
        public string AddProduct { get; } = "/api/v1/product/add";
        public string EditProduct { get; } = "/api/v1/product/edit";
        public string DeleteProduct { get; } = "/api/v1/product/{0}/remove";
    }
}