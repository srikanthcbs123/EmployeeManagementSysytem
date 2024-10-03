using EmployeeManagementSystem.AbstractLayer;
using EmployeeManagementSystem.Entity;
using EmployeeManagementSytem.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.ManagerLayer
{
    public class EmployeeManager : IManager
    {
        IRepository repository;

        public EmployeeManager(IRepository _repository)
        {
            repository = _repository;
        }
        /// <summary>
        /// To pass the details to EmployeeRepository to Add Employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool AddEmployeeDetils(Employee employee)
        {
            repository.AddEmployeeDetils(employee);
            return true; 
        }
        /// <summary>
        /// To pass the id to EmployeeRepository to Delete Employee Details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteEmployeeDetilsById(int id)
        {
            var emp = repository.DeleteEmployeeDetilsById(id);
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
        public List<Employee> GetAllEmployeeDetails()
        {
            var employee = repository.GetAllEmployeeDetails();
            return employee;
        }
        /// <summary>
        /// To pass the id to EmployeeRepository to Get Employee Details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Employee> GetEmployeeDetailsById(int id)
        {
            var employee = repository.GetEmployeeDetailsById(id);
            return employee;            
        }
    }
}