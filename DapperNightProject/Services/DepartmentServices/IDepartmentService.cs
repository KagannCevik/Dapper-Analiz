using DapperNightProject.Dtos.DepartmentDtos;

namespace DapperNightProject.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        Task<List<ResultDepartmentDto>> GetAllDepartmentAsync();
        Task CreateDepartmentAsync(CreateDepartmentDto createDepartmentDto);
        Task UpdateDepartmentAsync(UpdateDepartmentDto updateDepartmentDto);
        Task DeleteDepartmentAsync(int id);
        Task<GetDepartmentByIdDto> GetDepartmentByIdAsync(int id);
    }
}
