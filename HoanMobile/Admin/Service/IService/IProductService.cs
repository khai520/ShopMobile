using API.Models.DTO;

namespace Admin.Service.IService
{
    public interface IProductService : IApiService
    {
        public Task<List<ProductDTO>> GetAll();
        public Task<string> GetIdMonAn();
    }
}
