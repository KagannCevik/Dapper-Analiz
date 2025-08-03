using Dapper;
using DapperNightProject.Context;
using DapperNightProject.Dtos.EmployeeDtos;

namespace DapperNightProject.Services.EmployeeServices
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DapperContext _context;

        public EmployeeService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateEmployeeAsync(CreateEmployeeDto createEmployeeDto)
        {
            string query = "insert into Tblemployee (Name, Surname, Salary) values (@Name, @Surname, @Salary)";
            var parameters = new DynamicParameters();
            parameters.Add("@Name", createEmployeeDto.Name);
            parameters.Add("@Surname", createEmployeeDto.Surname);
            parameters.Add("@Salary", createEmployeeDto.Salary);
            var con = _context.CreateConnection();
            await con.ExecuteAsync(query, parameters);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            string query = "Delete From TblEmployee Where EmployeeId=@p1";
            var parameters=new DynamicParameters();
            parameters.Add("@p1", id);
            var conn = _context.CreateConnection();
            await conn.ExecuteAsync(query, parameters);
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "Select * From TblEmployee";
            var conn=_context.CreateConnection();
            var values=await conn.QueryAsync<ResultEmployeeDto>(query);
            return values.ToList();
        }

        public async Task<GetEmployeeByIdDto> GetEmployeeByIdAsync(int id)
        {
            string query= "Select * From TblEmployee Where EmployeeId=@id";
            var parameters= new DynamicParameters();
            parameters.Add("@id", id);
            var conn=_context.CreateConnection();
            var values = await conn.QueryFirstAsync<GetEmployeeByIdDto>(query, parameters);
            return values;
        }

        public async Task<List<ResultEmployeeWithDepartmentDto>> GetEmployeeWithDepartmentsAsync()
        {
            string query = "Select Name ,Surname,Salary,DepartmentName from TblEmployee Inner join TblDepartment on " +
                "TblEmployee.DepartmentId=TblDepartment.DepartmentId";
            var conn = _context.CreateConnection();
            var values = await conn.QueryAsync<ResultEmployeeWithDepartmentDto>(query);
            return values.ToList();
        }
        public async Task UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto)
        {
            string query = "Update TblEmployee Set Name=@Name, Surname=@Surname, Salary=@Salary Where EmployeeId=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@Name", updateEmployeeDto.Name);
            parameters.Add("@Surname", updateEmployeeDto.Surname);
            parameters.Add("@Salary", updateEmployeeDto.Salary);
            parameters.Add("@id", updateEmployeeDto.EmployeeId);
            var conn = _context.CreateConnection();
            await conn.ExecuteAsync(query, parameters);
        }
    }
}
