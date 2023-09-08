using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeContext _context;
        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }

        public EmployeeRepository()
        {
        }

        public void SaveEmployee(EmpProfile employee)
        {
            _context.EmpProfiles.Add(employee);
            _context.SaveChanges();
        }
        public List<EmpProfile> GetAllEmployees()
        {
            return _context.EmpProfiles.ToList();
        }
        public EmpProfile GetEmployeeByCode(int empCode)
        {
            return _context.EmpProfiles.Find(empCode);
        }
        public void UpdateEmployee(EmpProfile employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteEmployee(int empCode)
        {
            var employee = _context.EmpProfiles.Find(empCode);
            _context.EmpProfiles.Remove(employee);
            _context.SaveChanges();
        }
    }
}
