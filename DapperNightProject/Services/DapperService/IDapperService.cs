using DapperNightProject.Dtos;

namespace DapperNightProject.Services.DapperService
{
    public interface IDapperService
    {
        Task<List<Record>> GetAllRecordAsync();
        Task<int> GetRecordCountAsync();

    }
}
