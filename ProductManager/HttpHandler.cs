using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

namespace ProductManager
{
    internal class HttpHandler
    {
        #region props

        public HttpClient HttpClient { get; set; } = new HttpClient()
        {
            BaseAddress = new Uri("http://144.76.198.141:6789")
        };

        #endregion

        #region public
        public HttpHandler(string authToken)
        {
            this.HttpClient.DefaultRequestHeaders.Add("X-Api-Key", authToken);
        }


        public List<Product> GetAllProductsAsync(string path)
        {
            try
            {
                var result = this.HttpClient.GetAsync(path).GetAwaiter().GetResult();

                var body = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                return JsonSerializer.Deserialize<List<Product>>(body);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Product GetProductAsync(string path)
        {
            try
            {
                var result = this.HttpClient.GetAsync(path).GetAwaiter().GetResult();

                var body = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                return JsonSerializer.Deserialize<Product>(body);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public HttpResponseMessage PostAddProduct(string path, Product product)
        {
            try
            {
                var content = JsonSerializer.Serialize(product);

                return this.HttpClient.PostAsync(path, new StringContent(content)).GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public HttpResponseMessage PutEditProduct(string path, Product product)
        {
            try
            {
                var content = JsonSerializer.Serialize(product);

                return this.HttpClient.PutAsync(path, new StringContent(content)).GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public HttpResponseMessage DeleteProduct(string path)
        {
            try
            {
                return this.HttpClient.DeleteAsync(path).GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        #endregion

        #region private

        

        #endregion
    }
}