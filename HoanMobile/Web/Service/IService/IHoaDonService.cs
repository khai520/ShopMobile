using API.Models;

namespace Web.Service.IService
{
    public interface IHoaDonService
    {
        Task<bool> LichSuTrangThai(Guid orderId, string newStatus, string reason);
        Task<List<LichSuTrangThai>> GetLichSuTrangThaiByHoaDon(string hoadonId);
        Task<List<LichSuTrangThai>> GetLichSu(string hoadonId);
    }
}
