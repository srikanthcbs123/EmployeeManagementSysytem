using EmployeeManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement_System.AbstractLayer
{
    public interface IModelManager
    {
        List<EmployeeModel> GetAllEmployeeDetails();
        List<EmployeeModel> GetEmployeeDetailsById(int id);
        bool AddEmployeeDetils(EmployeeModel employee);
        bool DeleteEmployeeDetilsById(int id);
    }
}
