using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIApp.Models
{
  public  interface IEmployeeService
    {
        public List<Employee> GetEmployees();
        void AddEmployee(Employee employee); 
    }
}
