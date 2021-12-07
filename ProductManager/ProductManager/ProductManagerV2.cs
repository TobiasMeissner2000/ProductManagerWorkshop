using System;
using System.Collections.Generic;
using System.Net.Http;
using ProductManager.Data;
using ProductManager.Models;

namespace ProductManager.ProductManager
{
    public class ProductManagerV2
    {
        #region props

        private HttpHandler HttpHandler { get; }
        private ApiToken apiToken { get; set; } = new ApiToken();
        private V2Pathes v2Pathes { get; } = new V2Pathes();

        #endregion

        #region fields

        private string authToken = string.Empty;
        private readonly string ip = "http://144.76.198.141:6789";

        #endregion

        #region public

        public ProductManagerV2(string authToken)
        {
            this.HttpHandler = new HttpHandler(this.ip);
            this.authToken = authToken;
            this.SetNewAuthToken();
        }

        private bool IsApiTokenValid()
        {
            return this.apiToken.Validity < DateTime.Now;
        }

        private void SetNewAuthToken()
        {
            this.apiToken = this.HttpHandler.GetAccessToken(this.ip + this.v2Pathes.Authenticate, this.authToken);
            this.HttpHandler.SetAccessToken(this.apiToken);
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                if (!this.IsApiTokenValid())
                    this.SetNewAuthToken();

                return this.HttpHandler.GetAllProducts(this.v2Pathes.GetAllProducts);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Product GetProductByID(string id)
        {
            try
            {
                if (!this.IsApiTokenValid())
                    this.SetNewAuthToken();

                var s = this.v2Pathes.GetProduct;
                return this.HttpHandler.GetProduct(string.Format(this.v2Pathes.GetProduct, id));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public HttpResponseMessage AddProduct(Product product)
        {
            try
            {
                if (!this.IsApiTokenValid())
                    this.SetNewAuthToken();

                return this.HttpHandler.PostAddProduct(this.v2Pathes.AddProduct, product);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public HttpResponseMessage EditProductById(Product product)
        {
            try
            {
                if (!this.IsApiTokenValid())
                    this.SetNewAuthToken();

                return this.HttpHandler.PutEditProduct(this.v2Pathes.EditProduct, product);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public HttpResponseMessage RemoveProductById(string id)
        {
            try
            {
                if (!this.IsApiTokenValid())
                    this.SetNewAuthToken();

                return this.HttpHandler.DeleteProduct(string.Format(this.v2Pathes.DeleteProduct, id));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Review> GetAllReviews(string productId)
        {
            try
            {
                if (!this.IsApiTokenValid())
                    this.SetNewAuthToken();

                return this.HttpHandler.GetAllReviews(string.Format(this.v2Pathes.GetAllProductsReview, productId));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Review GetReviewById(string productId, string reviewId)
        {
            try
            {
                if (!this.IsApiTokenValid())
                    this.SetNewAuthToken();

                return this.HttpHandler.GetReview(string.Format(this.v2Pathes.GetProductReview, productId, reviewId));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public HttpResponseMessage AddReviewById(string productId, Review review)
        {
            try
            {
                if (!this.IsApiTokenValid())
                    this.SetNewAuthToken();

                return this.HttpHandler.PostAddReview(string.Format(this.v2Pathes.AddProductReview, productId), review);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public HttpResponseMessage EditReviewById(string productId, Review review)
        {
            try
            {
                if (!this.IsApiTokenValid())
                    this.SetNewAuthToken();

                return this.HttpHandler.PutEditReview(this.v2Pathes.EditProduct, review);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        #endregion
    }
}
