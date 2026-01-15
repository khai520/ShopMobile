
using API.Models.DTO;

namespace Web.Service.IService
{
    public interface IChiTietProductService : IApiService
    {
        Task<List<ChiTietProductDTO>> GetChiTiet(string Id);
        Task<List<ChiTietProductDTO>> GetAll();

    }
}
