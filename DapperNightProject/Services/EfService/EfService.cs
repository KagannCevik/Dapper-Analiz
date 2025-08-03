using DapperNightProject.Context;
using DapperNightProject.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DapperNightProject.Services.EfService
{
    public class EfService : IEfService
    {
        private readonly MyContextDb _context;

        public EfService(MyContextDb context)
        {
            _context = context;
        }

        public async Task<List<Record>> GetAllRecordsAsync()
        {
            return await _context.Records.ToListAsync();
        }

        public async Task<int> GetRecordCountAsync()
        {
            return await _context.Records.CountAsync();
        }
        
    }
}
