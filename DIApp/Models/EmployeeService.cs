using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIApp.Models
{
    public class EmployeeService:IEmployeeService 
    {
        public List<Employee> Employees;
        public EmployeeService()
        {
            Employees = new List<Employee>()
            {
                new Employee(){Id=111,Fname="Rakesh",Lname="Prajapati"},
                new Employee(){Id=112,Fname="Rohan",Lname="Prajapati"},
                new Employee(){Id=113,Fname="Gaurav",Lname="Prajapati"}
            };
        }
        public List<Employee> GetEmployees()
        {
            return this.Employees;
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
