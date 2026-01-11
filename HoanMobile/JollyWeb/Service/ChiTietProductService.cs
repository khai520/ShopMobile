
using API.Models.DTO;
using Azure;
using JollyWeb.Service.IService;

namespace JollyWeb.Service
{
    public class ChiTietProductService : ApiService, IChiTietProductService
    {
        private readonly HttpClient _httpclient;
        public ChiTietProductService(HttpClient httpClient) : base(httpClient)
        {
            _httpclient = httpClient;
        }

        public async Task<List<ChiTietMonAnDTO>> GetChiTiet(string id)
        {
            try
            {
                var response = await _httpclient.GetAsync($"ChiTietProduct/monan/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<List<ChiTietMonAnDTO>>();
                    return data ?? new List<ChiTietMonAnDTO>();
                }
                return new List<ChiTietMonAnDTO>();
            }
            catch (Exception)
            {
                return new List<ChiTietMonAnDTO>();
            }
        }
        public async Task<List<ChiTietMonAnDTO>> GetAll()
        {

            try
            {
                    var response = await _httpclient.GetAsync("ChiTietProduct/all");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<List<ChiTietMonAnDTO>>();
                    return data ?? new List<ChiTietMonAnDTO>();
                }
                return new List<ChiTietMonAnDTO>();
            }
            catch (Exception)
            {
                return new List<ChiTietMonAnDTO>();
            }
        }

    }
}
