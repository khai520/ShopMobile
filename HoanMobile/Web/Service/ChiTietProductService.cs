
using API.Models.DTO;
using Azure;
using Web.Service.IService;

namespace Web.Service
{
    public class ChiTietProductService : ApiService, IChiTietProductService
    {
        private readonly HttpClient _httpclient;
        public ChiTietProductService(HttpClient httpClient) : base(httpClient)
        {
            _httpclient = httpClient;
        }

        public async Task<List<ChiTietProductDTO>> GetChiTiet(string id)
        {
            try
            {
                var response = await _httpclient.GetAsync($"ChiTietProduct/product/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<List<ChiTietProductDTO>>();
                    return data ?? new List<ChiTietProductDTO>();
                }
                return new List<ChiTietProductDTO>();
            }
            catch (Exception)
            {
                return new List<ChiTietProductDTO>();
            }
        }
        public async Task<List<ChiTietProductDTO>> GetAll()
        {

            try
            {
                    var response = await _httpclient.GetAsync("ChiTietProduct/all");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<List<ChiTietProductDTO>>();
                    return data ?? new List<ChiTietProductDTO>();
                }
                return new List<ChiTietProductDTO>();
            }
            catch (Exception)
            {
                return new List<ChiTietProductDTO>();
            }
        }

    }
}
