using Newtonsoft.Json;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.API.Data
{
    public class JsonProductsProvider : IProductsProvider
    {
        private const string DATA_FILENAME = "data.json";

        private readonly Dictionary<Guid, Product> _products = new Dictionary<Guid, Product>();

        public JsonProductsProvider()
        {
            if (File.Exists(DATA_FILENAME))
            {
                var products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(DATA_FILENAME));
                products.ForEach(x => _products[x.Id] = x);
            }
        }

        public async Task AddAsync(Product product)
        {
            product.Id = Guid.NewGuid();

            _products[product.Id] = product;

            await SaveDataAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            Product oldProduct = await GetAsync(product.Id);

            if (oldProduct == null)
            {
                throw new ArgumentException("Product not found");
            }

            oldProduct.Category = product.Category;
            oldProduct.Name = product.Name;
            oldProduct.Price = product.Price;

            await SaveDataAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            if (_products.Remove(id))
            {
                await SaveDataAsync();
            }
        }

        public Task<Product> GetAsync(Guid id)
        {
            _products.TryGetValue(id, out var product);
            return Task.FromResult(product);
        }

        public Task<List<Product>> GetAllAsync()
        {
            return Task.FromResult(_products
                .Values
                .OrderBy(x => x.Name)
                .ToList());
        }

        #region Helpers

        private Task SaveDataAsync()
        {
            return File.WriteAllTextAsync(DATA_FILENAME, JsonConvert.SerializeObject(_products.Values));
        }

        #endregion
    }
}
