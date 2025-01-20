
using SampleDataLib.Common;
using SampleDataLib.Data;
using SampleDataLib.Entities;
using System;
using System.IO;

namespace CSharpBasics
{
    internal class DllProgramming
    {
        const string type = "FILE";
        const string menuFile = "C:\\Trainings\\Capgemini-Dec24\\CapgeminiTraining\\CSharpBasics\\EmpMgrMenu.txt";
        static void Main(string[] args)
        {
            var menu = File.ReadAllText(menuFile);
            var processing = false;
            do
            {
                var choice = ConsoleIO.GetValue(menu);
                processing = ProcessMenu(choice);
                Console.WriteLine("Press any key to clear");
                Console.ReadKey();
                Console.Clear();
            }
            while(processing);
        }

        private static bool ProcessMenu(int choice)
        {
            switch(choice)
            {
                case 1:
                    addingEmpFeature();
                    break;
                case 2:
                case 3:
                case 4:
                    findingEmployeeFeature();
                    break;
                default:
                    return false;
            }
            return true;
        }

        private static void findingEmployeeFeature()
        {
            //create the component
            var component = EmployeeFactory.GetManager(type);
            //call the getallemployees api
            var records = component.GetAllEmployees();
            //iterate thru the list
            foreach(var record in records)
            {
                //display all data.
                var display = $"Name : {record.Name} | Address : {record.Address} |   Salary : {record.Salary} | Id : {record.Id}";
                Console.WriteLine(display);
            }
        }

        private static void addingEmpFeature()
        {
            //take inputs from the user.
            var id = ConsoleIO.GetValue("Enter the Id");
            var name = ConsoleIO.GetString("Enter the Name");
            var address = ConsoleIO.GetString("Enter the Address");
            var salary = ConsoleIO.GetValue("Enter the Salary");
            //create the Employee object
            var emp = new Employee
            {
                Address = address,
                Id = id,
                Name = name,
                Salary = salary
            };
            //create the component
            IEmployeeManager mgr = EmployeeFactory.GetManager(type);
            //call the method of the component. 
            try
            {
                mgr.AddNewEmployee(emp);
                Console.WriteLine("Employee Added sucessfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //handle exceptions if any
        }
    }
}
