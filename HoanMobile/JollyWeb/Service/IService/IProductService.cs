using API.Models.DTO;

namespace JollyWeb.Service.IService
{
    public interface IProductService : IApiService
    {
        public Task<string> GetIdMonAn();
        public Task<List<ProductDTO>> GetAll();
    }
}
