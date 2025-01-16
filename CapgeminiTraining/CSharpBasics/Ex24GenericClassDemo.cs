using System;
using System.Collections.Generic;

namespace CSharpBasics
{
    //Generic class
    class Repo<T> where T : class //T must be Value type, where shall define what kind of data type that is allowed on this class. We call this as Constraints.
    {
        private List<T> _list = new List<T>();

        public void AddItemToRepo(T item) => _list.Add(item);

    }
    class GenericClass
    {
        
        static void Main(string[] args)
        {
            Repo<string> stringRepo = new Repo<string>();
            stringRepo.AddItemToRepo("123");
        }
    }
}