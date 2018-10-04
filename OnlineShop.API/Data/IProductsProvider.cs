using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.API.Data
{
    public interface IProductsProvider
    {
        Task AddAsync(Product product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Guid id);

        Task<Product> GetAsync(Guid id);

        Task<List<Product>> GetAllAsync();
    }
}