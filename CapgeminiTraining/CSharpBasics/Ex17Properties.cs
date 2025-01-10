using System;
/*
 * Properties in C# are data accessors(getters and setters) for the private data of the class. 
 * They can be used like fields. No need for parameters. 
 * They are primarily used to get/set values to the private fields(data) of the class. 
 * Older languages like C++ had methods to set the data, C# has a convinient way in the form of properties. 
 * Old version of the properties had an explicit get, set implementations in it. 
 * Newer version of the properties have a default or automatic get/set with no implementations. In this case, the .NET would generate an hidden field to each of the automatic property U create. 
 */
namespace CSharpBasics
{
    //old syntax of properties:
    class Customer
    {
        private int _id;
        

        //Accessors to the private fields. 
        public int CustomerId
        {
            get { return _id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("U  cannot set 0 to a customer id");
                };
                _id = value;
            } //value is the data that shall be set by the user. 
        }

        private string _name;

        public string CustomerName
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _email;

        public string CustomerEmail
        {
            get { return _email; }
            set { _email = value; }
        }

        private long _mobile;

        public long ContactNo
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

    }


    //Automatic properties of C#
    class Employee
    {
        private static int _no = 0;
        //Constructor: Same name of the class, no return type, can have args. 
        public Employee()
        {
            _no += 1;
            EmpId = _no;
        }
        public int EmpId { get; private set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }

        public int EmployeeSalary { get; set; }

    }


        internal class PropertiesExample
    {
        static void Main(string[] args)
        {
            //CustomerExample();
            EmployeeExample();
        }

        private static void EmployeeExample()
        {
            Employee example = new Employee();
            example.EmployeeSalary = 50000;
            example.EmployeeName = "TstName";
            example.EmployeeAddress = "Bangalore";
            Console.WriteLine("Display the data ");

            Employee temp = new Employee
            {
                EmployeeAddress = "Chennai",
                EmployeeName = "Sunder",
                EmployeeSalary = 56000
            };//new object initialization syntax of C#
        }

        private static void CustomerExample()
        {
            Customer cst = new Customer();
            cst.CustomerId = 123;
            cst.CustomerName = "Phaniraj";
            cst.CustomerEmail = "phanirajbn@gmail.com";
            cst.ContactNo = 2342423423;

            Console.WriteLine($"The name entered is {cst.CustomerName} with mobile no {cst.ContactNo} and he has registered his email as {cst.CustomerEmail}");
        }
    }
}
