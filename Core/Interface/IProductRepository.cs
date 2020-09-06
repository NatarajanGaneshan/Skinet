using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.Interface
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id); 

        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}