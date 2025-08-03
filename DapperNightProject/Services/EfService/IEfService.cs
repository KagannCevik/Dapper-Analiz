using DapperNightProject.Context;
using DapperNightProject.Dtos;

namespace DapperNightProject.Services.EfService
{

    public interface IEfService
    {
        Task<List<Record>> GetAllRecordsAsync();
        Task<int> GetRecordCountAsync();
    }
}
