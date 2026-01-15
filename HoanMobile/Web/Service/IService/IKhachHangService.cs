using API.Models;
using API.Models.DTO;

namespace Web.Service.IService
{
    public interface IKhachHangService : IApiService
    {
        Task<List<KhachHangDTO>> GetAll();
    }
}
