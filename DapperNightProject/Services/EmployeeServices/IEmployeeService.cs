using DapperNightProject.Dtos.EmployeeDtos;

namespace DapperNightProject.Services.EmployeeServices
{
    public interface IEmployeeService
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        Task CreateEmployeeAsync(CreateEmployeeDto createEmployeeDto);
        Task UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto);
        Task DeleteEmployeeAsync(int id);
        Task<GetEmployeeByIdDto> GetEmployeeByIdAsync(int id);
        Task<List<ResultEmployeeWithDepartmentDto>> GetEmployeeWithDepartmentsAsync();
    }
}
