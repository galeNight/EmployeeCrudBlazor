using EmployeeCrudBlazor.Context;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrudBlazor.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EmployeeService(ApplicationDbContext applicationDbContext) 
        {
            _applicationDbContext = applicationDbContext;
        }
        //get all employees list
        public async Task<List<Employee>> GetAllEmpoyees()
        {
            return await _applicationDbContext.Employees.ToListAsync();
        }
        //add new employees
        public async Task<bool> AddNewEmployees(Employee employee)
        {
            await _applicationDbContext.Employees.AddAsync(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        // get employee record by id
        public async Task<Employee> GeTEmployeeById(int id)
        {
            Employee employee = await _applicationDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return employee;
        }
        //update employee data
        public async Task<bool>UpdateEmployeeDetails(Employee employee)
        {
            _applicationDbContext.Employees.Update(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        //delete employee data
        public async Task<bool>DeleteEmployee(Employee employee)
        {
            _applicationDbContext.Employees.Remove(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
