using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Entity
{
    /// <summary>
    /// EmpId -> Primary Key and auto incremented
    /// FirstName, LastName, Designation -> string
    /// Age -> int
    /// </summary>
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
    }
}
