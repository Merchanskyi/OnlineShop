using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.UI.Services
{
    public interface IHttpProductProvider
    {
        Task<List<Product>> GetAllAsync();

        Task<Product> GetAsync(Guid id);

        Task DeleteAsync(Guid id);

        Task AddAsync(Product product);

        Task UpdateAsync(Product product);
    }
}
