using API.Models;
using API.Models.DTO;

namespace Admin.Service.IService
{
    public interface IChiTietProductService : IApiService
    {
        Task<List<ChiTietProductDTO>> GetChiTiet(string Id);
        Task<List<ChiTietProductDTO>> GetAll();

    }
}
