namespace ProductManager.ProductManager
{
    public class ProductManagerV2
    {
        #region props

        private string authToken = string.Empty;

        #endregion

        #region public
        public ProductManagerV2()
        {

        }

        public ProductManagerV2(string authToken)
        {

        }

        public void SetAuthToken(string authToken)
        {

        }

        public void GetAllProductsAsync()
        {

        }

        public void GetProductByIDAsync()
        {

        }

        public void AddProductAsync()
        {

        }

        public void EditProductByIdAsync()
        {

        }

        public void RemoveProductById()
        {

        }

        #endregion

        #region private

        private bool IsAuthTokenEmpty()
        {
            return Equals(this.authToken, string.Empty);
        }

        #endregion
    }
}
