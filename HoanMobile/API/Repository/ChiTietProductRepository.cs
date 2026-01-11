using API.Data;
using API.Models;
using API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class ChiTietProductRepository : Repository<ChiTietProduct, Guid>, IChiTietProductRepository
    {
        private readonly DBAppContext _context;
        public ChiTietProductRepository(DBAppContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ChiTietProduct>> GetMonAnId(string id)
        {
            return await _context.chiTietMonAns
                .Where(x => x.ProductId == id)
                .Include(c => c.Product)
                .Include(c => c.BoNhoTrong)
                .Include(c => c.ChatLieu)
                .Include(c => c.KichCo)
                .Include(c => c.NhaCungCap)
                .Include(c => c.Anhs)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<ChiTietProduct>> GetAll()
        {
            return await _context.chiTietMonAns
                .Include(c => c.Product)
                .Include(c => c.BoNhoTrong)
                .Include(c => c.ChatLieu)
                .Include(c => c.KichCo)
                .Include(c => c.NhaCungCap)
                .Include(c => c.Anhs)
                .AsNoTracking()
                .ToListAsync();
        }

    }
}
