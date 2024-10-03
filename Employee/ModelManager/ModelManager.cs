using EmployeeManagement_System.AbstractLayer;
using EmployeeManagementSystem.AbstractLayer;
using EmployeeManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement_System.DbContext.ModelManager
{
    public class ModelManager : IModelManager
    {
        IManager manager;
        public ModelManager(IManager _manager)
        {
            manager = _manager;
        }

        /// <summary>
        /// To pass the details to EmployeeManager to Add Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool AddEmployeeDetils(EmployeeModel employee)
        {
            Employee emp = new Employee();
            emp.EmpId = employee.EmpId;
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Age = employee.Age;
            emp.Designation = employee.Designation;
            manager.AddEmployeeDetils(emp);
            return true;
        }
        /// <summary>
        /// To pass the id to EmployeeManager to Delete Employee Details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteEmployeeDetilsById(int id)
        {
            var emp = manager.DeleteEmployeeDetilsById(id);
            if (emp == false)
            {
                return false;
            }
            else
            {

                return true;
            }
        }
        /// <summary>
        /// To Get All Employee Details
        /// </summary>
        /// <returns></returns>
        public List<EmployeeModel> GetAllEmployeeDetails()
        {
            List<Employee> employees = manager.GetAllEmployeeDetails();

            if (employees != null)
            {
                List<EmployeeModel> employeeModels = employees.Select(item => new EmployeeModel
                {
                    EmpId = item.EmpId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Age = item.Age,
                    Designation = item.Designation
                }).ToList();
                return employeeModels;
            }
            else
            {
                return null;
            }
           
        }
        /// <summary>
        /// To pass the id to Employeemanager to Get Employee Details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<EmployeeModel> GetEmployeeDetailsById(int id)
        { 
            List<Employee> employees = manager.GetEmployeeDetailsById(id);
            if(employees != null)
            {
                List<EmployeeModel> employeeModels = employees.Select(item => new EmployeeModel
                {
                    EmpId = item.EmpId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Age = item.Age,
                    Designation = item.Designation
                }).ToList();
                return employeeModels;
            }
            else
            {
                return null;
            }

        }
    }
}