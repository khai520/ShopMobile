using Admin.Service.IService;
using API.Models.DTO;
using System.Net.Http;

namespace Admin.Service
{
    public class ProductService : ApiService, IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductDTO>> GetAll()
        {
            try
            {
                var response = await _httpClient.GetAsync("Product/all");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<List<ProductDTO>>();
                    return data ?? new List<ProductDTO>();
                }
                return new List<ProductDTO>();
            }
            catch (Exception)
            {
                return new List<ProductDTO>();
            }
        }

        public async Task<string> GetIdMonAn()
        {

            var response = await _httpClient.GetAsync("Product/GenerateMonAnId");
            if (response.IsSuccessStatusCode)
            {
                var rawString = await response.Content.ReadAsStringAsync();
                return rawString;
            }
            else
            {
                return default;
            }
        }
    }
}
