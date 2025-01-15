using System;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Net.Http.Headers;
/*
 * Collections is a namespace that contain classes which shall help in creating Data structures. 
 * There are 2 versions NonGeneric and Generic(C# 2.0).
 * NonGeneric is not typesafe. 
 * Generic is type specific, UR data is ensured to be of the specific type.
 * All classes in Collections will implement certain interfaces that provides the features. 
 * Collections are expected to be iterable(IEnumerable), some of them allow to add/remove anywhere(IList), some shall be groupable(ICollection). 
 * Most popular collection class is ArrayList. 
 * IEnumerable vs. IEnumerator
 * IComparable vs. IComparer. 
 * How to create a Custom Collection Class. 
 */
namespace CSharpBasics
{
    internal class NonGenericCollections
    {
        static void Main(string[] args)
        {
            //ArrayListExample();
            HashtableExample();

        }

        private static void HashtableExample()
        {
            
            //Collection of data in the form or key-value pairs. 
            Hashtable users = new Hashtable();
            
            RETRY:
            string username = ConsoleIO.GetString("Enter the username to sign up");
            string pwd = ConsoleIO.GetString("Enter the Password");
            if (users.ContainsKey(username))
            {
                Console.WriteLine("User already exisits");
                goto RETRY;
            }
            users[username] = pwd;//If the username already exists, it shall replace the value. 
            Console.WriteLine("The Current User list: " + users.Count);

            username = ConsoleIO.GetString("Enter the username to login");
            pwd = ConsoleIO.GetString("Enter the password");
            if (!users.ContainsKey(username))
            {
                Console.WriteLine("Invalid Username");
            }
            else
            {
                if (users[username].ToString() != pwd)
                {
                    Console.WriteLine("Invalid password");
                }
                else
                {
                    Console.WriteLine($"Welcome Mr./Ms. {username}");
                }
            }
            foreach (string key in users.Keys)
            {
                Console.WriteLine($"{key}: {users[key]}");
            }
        }

        private static void ArrayListExample()
        {
            ArrayList list = new ArrayList();
            list.Add("Apples");
            list.Add("Mangoes");
            list.Add("Oranges");
            list.Add("PineApples");
            list.Add("Custard Apples");

            Console.WriteLine("The total no of fruits: " + list.Count);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove("Oranges");
            list.Insert(3, 1234);//Collection classes are not typesafe. 
            Console.WriteLine("The total no of fruits: " + list.Count);
        }
    }
}
