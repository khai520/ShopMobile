using API.Models.DTO;

namespace Web.Service.IService
{
    public interface IProductService : IApiService
    {
        public Task<string> GetId();
        public Task<List<ProductDTO>> GetAll();
    }
}
