using DAL; // Import the DAL namespace
using System.Collections.Generic;

namespace BusinessLogic
{
    public class EmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // Define methods here to interact with the DAL
        public void SaveEmployee(EmpProfile employee)
        {
            _employeeRepository.SaveEmployee(employee);
        }

        public List<EmpProfile> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public EmpProfile GetEmployeeByCode(int empCode)
        {
            return _employeeRepository.GetEmployeeByCode(empCode);
        }

        public void UpdateEmployee(EmpProfile employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }

        public void DeleteEmployee(int empCode)
        {
            _employeeRepository.DeleteEmployee(empCode);
        }
    }
}
