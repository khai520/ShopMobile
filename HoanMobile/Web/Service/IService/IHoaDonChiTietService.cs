using API.Models.DTO;

namespace Web.Service.IService
{
    public interface IHoaDonChiTietService :IApiService
    {
        Task<List<HoaDonChiTietDTO>> GetChiTiet(string Id);
    }
}
