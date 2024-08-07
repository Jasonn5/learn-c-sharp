using DataAccess.Repositories.Interfaces;
using Entities;
using Services.Interfaces;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository) 
        {
            _employeeRepository = employeeRepository;
        }
        public ICollection<Employee> List()
        {
            return _employeeRepository.list();
        }
    }
}
