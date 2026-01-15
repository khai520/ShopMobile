using API.Models;
using API.Models.DTO;
using API.Models.ViewModels;

namespace Web.Service.IService
{
    public interface ITaiKhoanService : IApiService
    {
        public Task<TaiKhoanKHDTO> Login(LoginViewModel username);
        public Task<string?> CheckTk(string username, string sdt);
        public Task<bool> AddTaiKhoanAsync(TaiKhoan model);
    }
}
