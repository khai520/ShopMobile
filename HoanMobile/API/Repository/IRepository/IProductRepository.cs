using API.Models;

namespace API.Repository.IRepository
{
    public interface IProductRepository : IRepository <Product , string>
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(string id);
    }
}
