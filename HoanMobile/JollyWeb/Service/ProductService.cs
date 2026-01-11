using API.Models.DTO;
using JollyWeb.Service.IService;
using System.Net.Http;

namespace JollyWeb.Service
{
    public class ProductService : ApiService, IProductService
    {
        HttpClient _httpClient;
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
