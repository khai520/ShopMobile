using API.Models;
using API.Models.DTO;

namespace API.Repository.IRepository
{
    public interface IChiTietProductRepository : IRepository<ChiTietProduct , Guid>
    {
        Task<IEnumerable<ChiTietProduct>> GetProductId(string Id);

        Task<IEnumerable<ChiTietProduct>> GetAll();
    }
}
