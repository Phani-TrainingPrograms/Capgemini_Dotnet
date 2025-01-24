using NUnit.Framework;
using SampleDataLib.Testing;
using System;
using System.Collections.Generic;
namespace NUnitTesting
{
    public class EmpManagerTests
    {
        private EmpRepo empRepo;
        [SetUp] //Invoked only once like Constructor
        public void Setup()
        {
            empRepo = new EmpRepo();
        }

        [Test]
        public void AddNewEmployee_ValidEmployee_ShouldAddSuccessfully()
        {
            //Arrange
            var emp = new Employee { EmpId = 1, EmpAddress = "BLR", EmpName = "Phani", EmpSalary = 400 };
            //Act
            empRepo.AddNewEmployee(emp);
            //Assert
            Assert.AreEqual(emp.EmpName, empRepo.GetEmployeeById(1).EmpName);
        }

        [Test]
        public void AddNewEmployee_DuplicateId_ShouldThrowArgumentException()
        {
            var emp = new Employee { EmpId = 1, EmpAddress = "BLR", EmpName = "Phani", EmpSalary = 400 };
            empRepo.AddNewEmployee(emp);

            Assert.Throws<ArgumentException>(() => empRepo.AddNewEmployee(emp));
        }

        [Test]
        public void GetEmployeeById_NonExistantEmployee_ShouldThrowKeyNotFoundException()
        {
            //Act and Assert
            Assert.Throws<KeyNotFoundException>(() => empRepo.GetEmployeeById(123));
        }

        [Test]
        public void GetAllEmployees_ShouldReturnAllEmployees()
        {
            //Arrange
            empRepo.AddNewEmployee(new Employee { EmpId = 1, EmpAddress = "BLR", EmpName = "Phani", EmpSalary = 400 });
            empRepo.AddNewEmployee(new Employee { EmpId = 2, EmpAddress = "MYS", EmpName = "Rani", EmpSalary = 200 });
            empRepo.AddNewEmployee(new Employee { EmpId = 3, EmpAddress = "HYD", EmpName = "Kumar", EmpSalary = 400 });
            empRepo.AddNewEmployee(new Employee { EmpId = 4, EmpAddress = "CHE", EmpName = "Kumari", EmpSalary = 100 });

            //Act
            var results = empRepo.GetAllEmployees();
            //Assert
            Assert.AreEqual(4, results.Count);
            Assert.AreEqual("Phani", results[0].EmpName);
            Assert.AreEqual("Rani", results[1].EmpName);
            Assert.AreEqual("Kumar", results[2].EmpName);
            Assert.AreEqual("Kumari", results[3].EmpName);
        }
    }
}