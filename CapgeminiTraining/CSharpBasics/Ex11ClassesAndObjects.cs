using System;
/*
 * A Class is a user defined type(UDT) which is like a composition of multiple data types represented as single unit that is relatable to the real world entity
 * A Class is a reference type in .NET. 
 * A Class is comprised of fields(data of the class), methods(functions of the class that are created to manipulate the data), properties(Accessors to the fields), events(actions that can be performed on the object) and some times, nested class.
 * Usually the data of the class is private(hidden to the outside world). 
 * To manipulate the data, we have accessors or Functions. 
 * Fields are now obelete. Instead we use properties.
 * However, if U want data that has to have some business rules in it, we still recommend to use fields and access them with functions. 
 * 
 */

namespace CSharpBasics
{
    class Book
    {
        int bookId;
        
        //properties of a class. 
        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        //From C# 3.0, we have Automatic properties which has get,set in it and no need to explicitly declare private members for the data. 
        public string Title { get; set; }

    }
    internal class ClassesAndObjects
    {
        static void Main(string[] args)
        {

        }
    }
}
