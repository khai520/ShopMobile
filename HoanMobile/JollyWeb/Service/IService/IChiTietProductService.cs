
using API.Models.DTO;

namespace JollyWeb.Service.IService
{
    public interface IChiTietProductService : IApiService
    {
        Task<List<ChiTietMonAnDTO>> GetChiTiet(string Id);
        Task<List<ChiTietMonAnDTO>> GetAll();

    }
}
