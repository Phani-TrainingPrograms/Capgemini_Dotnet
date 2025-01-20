using SampleDataLib.Common;
using SampleDataLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
namespace SampleDataLib.Entities
{
    /// <summary>
    /// Represents an Employee that is used in the Application.
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name},{Address},{Salary}\n";
        }
    }
}
namespace SampleDataLib.Data
{
    public interface IEmployeeManager
    {
        void AddNewEmployee(Employee employee);
        void DeleteEmployee(int id);
        void UpdateEmployee(int id, Employee employee);
        List<Employee> GetAllEmployees();
    }
    internal class EmployeeFileManager : IEmployeeManager
    {
        const string filename = "Employees.csv";
        List<Employee> _empList = new List<Employee>();
        public void AddNewEmployee(Employee employee)
        {
            try
            {
                //Check if the Employee is correct
                validateEmployee(employee);
                //Add record as a line to the file.
                File.AppendAllText(filename, employee.ToString());
                //Update the List in the memory.
                _empList.Add(employee);
            }
            catch (EmployeeException ex)
            {
                //log this error in the logger.
                throw ex;
            } 
        }

        private void validateEmployee(Employee employee)
        {
            if(employee == null)
            {
                throw new EmployeeException("Employee details are not set");
            }
            if (employee.Id <= 100)
            {
                throw new EmployeeException("Id should be greater than 100");
            }
            //implement other business validations
        }

        public void DeleteEmployee(int id)
        {
            //get all the data from the file
            _empList = getAllRecords();
            //find the rec matching
            
            foreach(var empRec in _empList)
            {
                if(empRec.Id == id)
                {
                    //delete the guy
                    _empList.Remove(empRec);
                }
            }
            updateFile(_empList);
            //update the list back to the file.

        }

        private void updateFile(List<Employee> empList)
        {
            //convert the list<Employee> into a List<string> lines. 
            string content = string.Empty;
            foreach (Employee emp in empList)
            {
                content += emp;
            }
            //write the lines into the file
            File.WriteAllText(filename, content);
        }

        private List<Employee> getAllRecords()
        {
            List<Employee> list = new List<Employee>();
            //Read all lines from the file into an array
            var data = File.ReadAllLines(filename);
            //iterate thru the lines and get each line
            foreach (var line in data)
            {
                //split line to words
                var words = line.Split(',');
                //convert words to Employee
                var emp = new Employee
                {
                    Id = int.Parse(words[0]),
                    Name = words[1],
                    Address = words[2],
                    Salary = int.Parse(words[3])  
                };
                //Add to the list
                list.Add(emp);
            }
            return list;
        }

        public List<Employee> GetAllEmployees()
        {
            var records = getAllRecords();
            return records;
        }

        public void UpdateEmployee(int id, Employee employee)
        {
            throw new NotImplementedException("Do It URSELF");
        }
    }

    public class EmployeeFactory
    {
        public static IEmployeeManager GetManager(string type)
        {
            if(type.ToUpper() == "FILE")
                return new EmployeeFileManager();
            else
                throw new NotImplementedException("This type is not implemented in our environment");
        }
    }
}
namespace SampleDataLib.Common
{
    public class EmployeeException : Exception
    {
        public EmployeeException() { }
        public EmployeeException(string message) : base(message) { }
        public EmployeeException(string message, Exception inner) : base(message, inner) { }
        
    }
}