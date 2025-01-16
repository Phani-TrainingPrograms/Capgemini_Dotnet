using System;
using System.Collections.Generic;
using System.IO;
/*
 * All classes related to file io comes from the namespace System.IO. 
 * Files uses Streams to send input and extract output. 
 * Streams are continuous memory of data that is mostly unidirectional. 
 * Stream is an abstract class that is implemented by various classes/ StreamReader and StreamWriter are the important classes. 
 * File class is a static class that helps in creating, reading and writing data to files. 
 * DirectoryInfo to create and work with directories of the File System
 */

namespace CSharpBasics
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int EmpSalary { get; set; }
    }
    internal class Filehandling
    {
        static void Main(string[] args)
        {
            //writingToFile();            
            //readingFromFile();
            //writeCsvFile(new Employee { EmpId = 123, EmpName = "Phaniraj", EmpAddress = "Bangalore", EmpSalary = 56000 });
            var data = readCsvFile();
            foreach (var emp in data)
            {
                Console.WriteLine(emp.EmpName);
            }
        }

        private static void writeCsvFile(Employee emp)
        {
            var fileName = "Employees.csv";
            var line = $"{emp.EmpId},{emp.EmpName}, {emp.EmpAddress}, {emp.EmpSalary}\n";
            File.AppendAllText(fileName, line);
        }

        private static List<Employee> readCsvFile()
        {
            var fileName = "Employees.csv";
            var list = new List<Employee>();
            var contents = File.ReadAllLines(fileName);
            foreach(var line in contents)
            {
                var words = line.Split(',');
                var emp = new Employee
                {
                    EmpId = int.Parse(words[0]),
                    EmpName = words[1],
                    EmpAddress = words[2],
                    EmpSalary = int.Parse(words[3])
                };
                list.Add(emp);
            }   
            return list;
        }

        private static void readingFromFile()
        {
            string fileName = "Info.txt";
            var contents = File.ReadAllText(fileName);
            Console.WriteLine(contents);
        }

        private static void writingToFile()
        {
            string fileName = "Info.txt";
            File.WriteAllText(fileName, "Sample Content to the file");
            //If the file exists, opens the file for writing else, creates the file and writes to it. 
            File.AppendAllText(fileName, "\nSome more content to write");
        }
    }
}
