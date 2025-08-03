using Dapper;
using DapperNightProject.Context;
using DapperNightProject.Dtos;

namespace DapperNightProject.Services.DapperService
{
    public class DapperService : IDapperService
    {
        private readonly DapperContext _context;

        public DapperService(DapperContext context)
        {
            _context = context;
        }

        public async Task<List<Record>> GetAllRecordAsync()
        {
            string query = "SELECT * FROM Records";
            var conn = _context.CreateConnection();
            var records = await conn.QueryAsync<Record>(query);
            return records.ToList();
        }

        public async Task<int> GetRecordCountAsync()
        {
            string query = "Select Count(*) From Records";
            var conn = _context.CreateConnection();
            var recordCount = await conn.ExecuteScalarAsync<int>(query);
            return recordCount;
        }
    }
}
