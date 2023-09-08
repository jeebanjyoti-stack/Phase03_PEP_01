using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IEmployeeRepository
    {
        void SaveEmployee(EmpProfile employee);
        List<EmpProfile> GetAllEmployees();
        EmpProfile GetEmployeeByCode(int empCode);
        void UpdateEmployee(EmpProfile employee);
        void DeleteEmployee(int empCode);
    }
}
