using ProductManager.Data;
using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ProductManager.ProductManager
{
    public class ProductManagerV1
    {
        #region props

        private HttpHandler HttpHandler { get; }

        #endregion

        #region fields

        private string authToken = string.Empty;
        private readonly string ip = "http://144.76.198.141:6789";

        #endregion

        #region public

        public ProductManagerV1(string authToken)
        {
            this.authToken = authToken;
            this.HttpHandler = new HttpHandler(this.ip, authToken);
        }

        public void ChangeAuthToken(string authToken)
        {
            try
            {
                this.HttpHandler.SetAuthToken(authToken);
                this.authToken = authToken;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                return this.HttpHandler.GetAllProducts(V1Pathes.GetAllProducts);
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
                return this.HttpHandler.GetProduct(string.Format(V1Pathes.GetProduct, id));
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
                return this.HttpHandler.PostAddProduct(V1Pathes.AddProduct, product);
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
                return this.HttpHandler.PutEditProduct(V1Pathes.EditProduct, product);
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
                return this.HttpHandler.DeleteProduct(string.Format(V1Pathes.DeleteProduct, id));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}