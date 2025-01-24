using System;
using System.Collections.Generic;

namespace SampleDataLib.Testing
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int EmpSalary { get; set; }
    }

    public class EmpRepo
    {
        private Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();

        public void AddNewEmployee(Employee employee)
        {
            //check for the id, if found throw exception. 
            if(_employees.ContainsKey(employee.EmpId))
            {
                throw new ArgumentException("The Employee already exists");
            }
            _employees[employee.EmpId] = employee;//try Urself what actually happens.
            //Add the record to the dictionary
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            foreach(var pair in _employees)
            {
                employees.Add(pair.Value);
            }
            return employees;
            //var employees = _employees.Values.ToList<Employee>();
        }

        public Employee GetEmployeeById(int id)
        {
            if( _employees.ContainsKey(id))
            {
                return _employees[id];
            }
            throw new KeyNotFoundException("Employee not found");
        }

        public void DeleteEmployee(int id)
        {
            if(_employees.ContainsKey(id))
            {
                _employees.Remove(id);
            }
            throw new KeyNotFoundException("Employee not found to delete");
        }

        public void UpdateEmployee(int id, Employee emp)
        {
            throw new NotImplementedException("Do it Urself");
        }
    }
}
