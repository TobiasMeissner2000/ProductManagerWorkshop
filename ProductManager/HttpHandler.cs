using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ProductManager
{
    internal class HttpHandler
    {
        #region props

        public HttpClient HttpClient { get; set; } = new HttpClient();

        #endregion

        #region public

        public HttpHandler(string ip, string authToken)
        {
            this.HttpClient.BaseAddress = new Uri(ip);
            this.HttpClient.DefaultRequestHeaders.Add("X-Api-Key", authToken);
        }

        public HttpHandler(string ip)
        {
            this.HttpClient.BaseAddress = new Uri(ip);
        }

        public void SetAuthToken(string authToken)
        {
            try
            {
                var baseAdress = this.HttpClient.BaseAddress;
                this.HttpClient = new HttpClient()
                {
                    BaseAddress = baseAdress,
                };
                this.HttpClient.DefaultRequestHeaders.Add("X-Api-Key", authToken);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SetAccessToken(ApiToken apiToken)
        {
            try
            {
                var baseAdress = this.HttpClient.BaseAddress;
                this.HttpClient = new HttpClient()
                {
                    BaseAddress = baseAdress,
                };
                this.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"0:{apiToken.Token}")));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ApiToken GetAccessToken(string uri, string authToken)
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Api-Token", authToken);

                var responseMessage = client.GetAsync(uri).GetAwaiter().GetResult();
                var body = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                return JsonSerializer.Deserialize<ApiToken>(body);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public List<Product> GetAllProductsAsync(string path)
        {
            try
            {
                var responseMessage = this.HttpClient.GetAsync(path).GetAwaiter().GetResult();

                var body = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                return JsonSerializer.Deserialize<List<Product>>(body);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Product GetProductAsync(string path)
        {
            try
            {
                var responseMessage = this.HttpClient.GetAsync(path).GetAwaiter().GetResult();

                var body = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                return JsonSerializer.Deserialize<Product>(body);
            }
            catch (Exception e)
            {
                throw e;
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
                throw e;
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
                throw e;
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
                throw e;
            }
        }

        public List<Review> GetAllReviews(string path)
        {
            try
            {
                var responseMessage = this.HttpClient.GetAsync(path).GetAwaiter().GetResult();

                var body = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                return JsonSerializer.Deserialize<List<Review>>(body);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Review GetReview(string path)
        {
            try
            {
                var responseMessage = this.HttpClient.GetAsync(path).GetAwaiter().GetResult();

                var body = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                return JsonSerializer.Deserialize<Review>(body);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public HttpResponseMessage PostAddReview(string path, Review review)
        {
            try
            {
                var content = JsonSerializer.Serialize(review);

                return this.HttpClient.PostAsync(path, new StringContent(content)).GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public HttpResponseMessage PutEditReview(string path, Review review)
        {
            try
            {
                var content = JsonSerializer.Serialize(review);

                return this.HttpClient.PutAsync(path, new StringContent(content)).GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}