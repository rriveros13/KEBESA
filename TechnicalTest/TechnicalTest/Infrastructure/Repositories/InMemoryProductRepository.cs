using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalTest.Application.Interfaces;
using TechnicalTest.Domain.Entities;
namespace TechnicalTest.Repositories
{
    namespace Repositories
    {
        public class InMemoryProductRepository : IProductRepository
        {
            private readonly List<Product> _products = new();

            public Task<IEnumerable<Product>> GetAllAsync() => Task.FromResult(_products.AsEnumerable());

            public Task<Product?> GetByIdAsync(Guid id) =>
                Task.FromResult(_products.FirstOrDefault(p => p.Id == id));

            public Task CreateAsync(Product product)
            {
                product.Id = Guid.NewGuid();
                _products.Add(product);
                return Task.CompletedTask;
            }

            public Task UpdateAsync(Product product)
            {
                var index = _products.FindIndex(p => p.Id == product.Id);
                if (index != -1) _products[index] = product;
                return Task.CompletedTask;
            }

            public Task DeleteAsync(Guid id)
            {
                _products.RemoveAll(p => p.Id == id);
                return Task.CompletedTask;
            }
        }
    }
}
