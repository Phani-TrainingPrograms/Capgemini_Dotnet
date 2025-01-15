using System;
/*
 * Operator overloading is a feature of very OOP langauge that allows some operators to be overloaded (interpret it with a different meaning) to meet the business requirements. 
 * Most of the arithematic operators can be overloaded, but logical operators cannot be overloaded.(Is, As, And Or, =) 
 * All operator overloading methods must be static, it should return the Type that U R overloading the operator.
 * Methods should be static and must have operator keyword followed by the Operator U  R trying to overload. 
 * One of the parameters must be the type U R trying to overload upon.
 * Make a list of the operators that can be overloaded and the ones that cannot be overloaded. 
 * By using operator overloading, you can make your classes more expressive and easier to use.
 */
namespace CSharpBasics
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

        public override int GetHashCode()
        {
            return EmpId.GetHashCode();//returns the value
        }

        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            if (obj is Employee)
            {
                Employee emp = obj as Employee;//Typecasting
                if((emp.EmpName == this.EmpName) && (emp.Salary == this.Salary)) 
                    return true;
                else return false;
            }
            return false;
        }
        public static Employee operator +(Employee lhs, double rhs)
        {
            lhs.Salary += rhs;
            return lhs;
        }
        public static Employee operator -(Employee lhs, double rhs)
        {
            lhs.Salary -= rhs;
            return lhs;
        }

        public static implicit operator double(Employee lhs)
        {
            return lhs.Salary;
        }
    }
    internal class Ex21OperatorOverloading
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Salary = 2000;
            emp1 += 2000;
            Console.WriteLine("The Current salary is " + emp1.Salary);
            emp1 -= 500;
            Console.WriteLine("The Current salary is " + emp1.Salary);

            //U R setting the salary for the emp1
            emp1.Salary = 7000;

            double salary = emp1; //The Emp objct is implicitly converted to double as double is overloaded for the Emp object
        }
    }
}
