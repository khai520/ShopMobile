using API.Controllers;
using API.Data;
using API.HeThong;
using API.Models;
using API.Models.DTO;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ViewAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChiTietProductController : BaseController<ChiTietProduct, ChiTietProduct, Guid>
    {
        private readonly IChiTietProductRepository chiTietMonAn;
        public ChiTietProductController(IChiTietProductRepository repository, DBAppContext context, IMapper mapper, XulyId xulyId) : base(repository, context, mapper, xulyId)
        {
            chiTietMonAn = repository;
        }
        [HttpGet("product/{id}")]
        public async Task<IActionResult> GetId(string id)
        {
            var result = await chiTietMonAn.GetProductId(id);
            var dto = _mapper.Map<IEnumerable<ChiTietProductDTO>>(result);
            return Ok(dto);
        }
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<ChiTietProduct>>> GetAll()
        {
            var result = await chiTietMonAn.GetAll();
            var dto = _mapper.Map<IEnumerable<ChiTietProductDTO>>(result);
            return Ok(dto);
        }
    }
}
