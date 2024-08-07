using DataAccess.Repositories.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DbContext _dbContext;
        public EmployeeRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ICollection<Employee> list()
        {
            return _dbContext.Set<Employee>().ToList();
        }
    }
}
