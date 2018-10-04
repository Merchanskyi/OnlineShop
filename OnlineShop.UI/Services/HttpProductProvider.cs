using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace OnlineShop.UI.Services
{
    public class HttpProductProvider : IHttpProductProvider
    {
        private static HttpClient _httpClient;

        static HttpProductProvider()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5010/api/")
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task AddAsync(Product product)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("products", product);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
        }

        public async Task UpdateAsync(Product product)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync<Product>("products", product);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            string url = $"products/{id}";

            HttpResponseMessage response = await _httpClient.DeleteAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
        }

        public async Task<Product> GetAsync(Guid id)
        {
            Product product = null;

            string url = $"products/{id}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }

            return product;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            List<Product> products = null;

            HttpResponseMessage response = await _httpClient.GetAsync("products");

            if (response.IsSuccessStatusCode)
            {
                products = await response.Content.ReadAsAsync<List<Product>>();
            }

            return products;
        }
    }
}
