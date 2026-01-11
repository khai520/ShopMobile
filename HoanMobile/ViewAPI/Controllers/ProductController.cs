using API.Controllers;
using API.Data;
using API.HeThong;
using API.Models;
using API.Models.DTO;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ViewAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : BaseController<Product, ProductDTO, string>
    {
        private readonly IProductRepository monAnRepository;
        public ProductController(IProductRepository repository, DBAppContext context, IMapper mapper, XulyId xulyId) : base(repository, context, mapper, xulyId)
        {
            _useXulyIdGeneration = true;
            _idPrefix = "MB";
            _idColumnName = "Id";
            monAnRepository = repository;
        }
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var result = await monAnRepository.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<ProductDTO>>(result);
            return Ok(dto);
        }
    }
}
