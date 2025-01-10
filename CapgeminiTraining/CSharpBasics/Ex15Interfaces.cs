using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
/*
 * Interfaces are like abstract classes that have only abstract methods in it. 
 * The methods are all public, we dont use access specifier in an interface.
 * A class that implements an interface must implement all the methods, else it should be made as abstract.
 * A class can implement multiple interfaces at the same level. 
 * Interface names are usually prefixed with I. 
 * Try out an example on multiple interface implementation at one level. 
 * What is 2 interfaces have same method and signature and U wish to implement both the methods in the same class. 
 */

interface IExample
{
    void Test();
}

interface ISimple
{
    void Test();
}

//Find out what is implicit Implementation and explicit Implementation. 
class SimpleExample : IExample, ISimple
{
    public void Test()
    {
        throw new NotImplementedException();
    }
}
namespace CSharpBasics
{
    interface IBookManager
    {
        void AddBook(int id, string title, double price);
        void UpdateDetails(int id, string title, double price);
        void DeleteBook(int id);

        DataTable GetAllBooks();

    }

    /*
     * We need a file to store the data. One single file to store all the records.  
     * The data of the file should be read and converted to a DataTable.
     */
    class FileBookManager : IBookManager
    {
        const string fileName = "SapnaBookHouse.csv";
        public void AddBook(int id, string title, double price)
        {
            string line = $"{id}, {title}, {price}\n";
            File.AppendAllText(fileName, line);
        }

        public void DeleteBook(int id)
        {
            //do it similar to update. 
        }

        private DataTable createTable()
        {
            DataTable dt = new DataTable("Books");
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Cost", typeof(int));
            return dt;
        }
        
        public DataTable GetAllBooks()
        {
            var table = createTable();
            //Get all the lines of the file. 
            var lines = File.ReadAllLines(fileName);
            foreach(var line in lines)
            {
                var words = line.Split(',');
                DataRow row = table.NewRow();
                row[0] = words[0];
                row[1] = words[1];
                row[2] = words[2];
                table.Rows.Add(row);
            }
            return table;
        }

        public void UpdateDetails(int id, string title, double price)
        {
            //Start
            //Get all records into the table
            var table = this.GetAllBooks();
            var contents = string.Empty;
            //Find the matching record based on Id
            foreach(DataRow row in table.Rows)
            {
                if (row[0].ToString() == id.ToString())
                {
                    //Update the found record. 
                    row[1] = title;
                    row[2] = price;
                    table.AcceptChanges();
                }
                string line = $"{row[0]}, {row[1]}, {row[2]}\n";
                contents += line;
            }
            
            //Save all the data to the file. 
            File.WriteAllText(fileName, contents);
        }
    }
    internal class Ex15Interfaces
    {
        static void Main(string[] args)
        {
            IBookManager bookManager = new FileBookManager();
            //bookManager.AddBook(123, "2 States", 500);
            //bookManager.AddBook(124, "Professional C#", 650);
            //bookManager.AddBook(125, "The Ramayana", 350);

            //bookManager.UpdateDetails(123, "2 States by Chetan Bhagath", 550);
            //var table = bookManager.GetAllBooks();
            //foreach (DataRow row in table.Rows)
            //{
            //    Console.WriteLine(row[1]);
            //}

            ISimple sim = new SimpleExample();
            sim.Test();

            IExample ex = new SimpleExample();
            ex.Test();

        }
    }
}
