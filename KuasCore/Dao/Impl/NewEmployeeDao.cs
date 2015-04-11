using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employees1 = new Employee();
            employees1.Id = "Ludan";
            employees1.Name = "滷蛋";
            employees1.Age = 21;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "Wei";
            employees2.Name = "鄭晉維";
            employees2.Age = 21;
            employees.Add(employees2);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employees = new Employee();
            employees.Id = "Bear";
            employees.Name = "熊大";
            employees.Age = 10;

            return employees;
        }
    }
}
