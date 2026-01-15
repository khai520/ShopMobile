using API.Models.DTO;

namespace Web.Service.IService
{
    public interface INhanVienService : IApiService
    {
        Task<List<NhanVienDTO>> GetAll();
    }
}
