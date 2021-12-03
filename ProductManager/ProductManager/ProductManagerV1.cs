using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ProductManager.Data;

namespace ProductManager.ProductManager
{
    public class ProductManagerV1
    {
        #region props

        private string authToken = string.Empty;
        private HttpHandler HttpHandler { get; }
        private V1Pathes v1Pathes = new V1Pathes();

        #endregion

        #region public
  
        public ProductManagerV1(string authToken)
        {
            this.authToken = authToken;
            this.HttpHandler = new HttpHandler(authToken);
        }

        // public void ChangeAuthToken(string authToken)
        // {
        //     this.authToken = authToken;
        //      //HttpClient.ChangeHeader();
        // }

        public List<Product> GetAllProductsAsync()
        {
            try
            {
                return this.HttpHandler.GetAllProductsAsync(this.v1Pathes.GetAllProducts);
            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                throw e;
            }
        }

        public Product GetProductByIDAsync(string id)
        {
            try
            {
                var s = this.v1Pathes.GetProduct;
                return this.HttpHandler.GetProductAsync(this.v1Pathes.GetProduct, id);  //TODO
            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                throw e;
            }
        }

        public HttpResponseMessage AddProductAsync(Product product)
        {
            try
            {
                return this.HttpHandler.PostAddProduct($"/api/v1/product/add", product);
            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                throw e;
            }
        }

        public HttpResponseMessage EditProductByIdAsync(Product product)
        {
            try
            {
                return this.HttpHandler.PutEditProduct($"/api/v1/product/edit", product);
            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                throw e;
            }
        }

        public HttpResponseMessage RemoveProductById(string id)
        {
            try
            {
                return this.HttpHandler.DeleteProduct($"/api/v1/product/{id}/remove");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                throw e;
            }
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
