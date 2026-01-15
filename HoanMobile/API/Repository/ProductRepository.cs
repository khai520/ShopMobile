using API.Data;
using API.Models;
using API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class ProductRepository : Repository<Product, string>, IProductRepository
    {
        private readonly DBAppContext _context;
        public ProductRepository(DBAppContext context) : base(context)
        {
            _context = context;
            
        }

        public override async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.products
                .Include(m => m.ChiTietProduct)?
                .ThenInclude(m => m.Anhs)
                .Include(m => m.TheLoai)
                .Include(m => m.ThuongHieu)
                .ToListAsync();
        }

        public override async Task<Product> GetByIdAsync(string id)
        {
              return await _context.products
                .Include(m => m.TheLoai)
                .Include(m => m.ThuongHieu)
                .Include(m => m.ChiTietProduct)?
                .ThenInclude(m => m.Anhs)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
