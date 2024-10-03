using EmployeeManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.AbstractLayer
{
    public interface IManager
    {
        List<Employee> GetAllEmployeeDetails();
        List<Employee> GetEmployeeDetailsById(int id);
        bool AddEmployeeDetils(Employee employee);
        bool DeleteEmployeeDetilsById(int id);
    }
}
