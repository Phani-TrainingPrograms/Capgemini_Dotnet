using System;
using System.Collections.Generic;
using CSharpBasics.Collections;
using System.Linq;
/*
 * Introduced in C# 2.0(2005), it is type safe collections. U should always go for Generic Collections as no BOXING/UNBOXING is involved and it is type safe(U cannot have data of multiple data types into a collection).
 * It is based on Template concept. 
 * Most of the Collection Classes have the generic version, including the interfaces. 
 * All generic classes and interfaces are defined in System.Collections.Generic namespace. 
 */
namespace CSharpBasics
{
    
    internal class Ex23GenericCollections
    {
        static void Main(string[] args)
        {
            //ListExample();
            //HashSetExample();
            //HashSetOnEmployees();
            DictionaryExample();
           
        }

        private static void DictionaryExample()
        {
          Dictionary<int, Collections.Employee> empList = new Dictionary<int, Collections.Employee>();
            empList[1] = new Collections.Employee { EmpId = 1, EmpName = "Phaniraj", Salary = 50000 };
            empList[2] = new Collections.Employee { EmpId = 2, EmpName = "Phaniraj", Salary = 51000 };
            empList[3] = new Collections.Employee { EmpId = 3, EmpName = "Phaniraj", Salary = 50000 };
            empList[4] = new Collections.Employee { EmpId = 4, EmpName = "Phaniraj", Salary = 50000 };
            empList.Add(5, new Collections.Employee { EmpId = 5, EmpName = "Kumar", Salary = 45000 });

            foreach (var pair in empList)
            {
                Console.WriteLine($"Key:{pair.Key}, Value: {pair.Value}");
            }
        }


        private static void HashSetOnEmployees()
        {
            HashSet<Collections.Employee> employees = new HashSet<Collections.Employee>();
            employees.Add(new Collections.Employee { EmpId = 123, EmpName = "Phaniraj", Salary = 56000 });
            employees.Add(new Collections.Employee { EmpId = 123, EmpName = "Phaniraj", Salary = 56000 });
            foreach (Collections.Employee e in employees)
            {
                Console.WriteLine($"Name: {e.EmpName}, Hashvalue: {e.GetHashCode()}");
            }
            var list = employees.ToList();
            Console.WriteLine(list[0] == list[1]);
 //           Console.WriteLine("The count: " + employees.Count);
        }

        private static void HashSetExample()
        {
            //Similar to List, but holds only unique values. The Uniqueness is detemined by the hashvalue associated with the object.
            //A hashvalue is a unique no to identify an object at runtime which is set by the .NET RUNTIME when the object is created.
            HashSet<string> list = new HashSet<string>();
            list.Add("Tomatoes");
            list.Add("Onions");
            list.Add("Potatoes");
            if(!list.Add("Tomatoes")) //returns false
            {
                Console.WriteLine("Item already exists");
            }
            //list.Contains used to check if the item is in the collection or not. 
            Console.WriteLine("The Count: " + list.Count);
        }

        private static void ListExample()
        {
            /*
             * List<T> is the generic version of ArrayList. 
             * It allows to add, remove, insert data into the collection at runtime. 
             * Adds the element at the bottom of the list. 
             * U can also insert/remove the elements in b/w the List.
             * Count property is used to get the no of elements in the List.
             * List has indexer to access individual elements using index[]
             */
            List<string> list = new List<string>();
            list.Add("Apples");
            list.Add("Mangoes");
            list.Add("Oranges");
            list.Add("Bananas");
            list.Add("Grapes(Black)");
            list.Add("Grapes(Green)");
            list.Insert(3, "Kiwi Fruit");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The total count: " + list.Count);

            //try remove, removeat, indexof, FindIndex
        }
    }
}
