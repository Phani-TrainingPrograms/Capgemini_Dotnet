using ConsoleApp1.Entities;
using ConsoleApp1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//tasks:
//Create a Entity class called Data with Id, StringData, DateOfBirth, LongNo.
//Create a function that takes id, string, date, long as arg and it shall return an Entity class object. This function is written in the Program.cs and tested in the Main function.
//Create a Repo class called DataRepo and have in it functions to add, remove, update and find data. 
//Create a App Class that consumes the Repo class and has got all the data of the Repo class. 
//App class shall have a function called SortById, SortByName, SortByDateOfBirth and shall display the data in the prescribed format. 

namespace ConsoleApp1
{
    internal class Program
    {
        public EntityClass CreateObject(int id, string data, DateTime dateDate, long longValue)
        {
            var entityObj = new EntityClass
            {
                Id = id,
                DateOfBirth = dateDate,
                LongNo = longValue,
                StringData = data,
            };
            return entityObj;
        }

        static int CalculateAge(DateTime dateOfBirth)
        {
            var span = DateTime.Now - dateOfBirth;
            return (int)(span.TotalDays/365.25);
            //int age = DateTime.Now.Year - dateOfBirth.Year;
            //return age;
        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            //var obj = pg.CreateObject(123, "SomeData", DateTime.Parse("02/01/2025"), 23423424234);
            //Console.WriteLine($"{obj.StringData} and date is {obj.DateOfBirth.ToLongDateString()}");
            //int age = CalculateAge(DateTime.Parse("01/12/1976"));
            ////Display the age here....
            //Console.WriteLine($"The age is {age}");
            List<EntityClass> list = new List<EntityClass>();
            
            var obj = pg.CreateObject(111, "TestData1", DateTime.Now.AddDays(234), 234234234); 
            list.Add(obj);
            obj =  pg.CreateObject(112, "AppleData", DateTime.Now.AddDays(123), 234234234);
            list.Add(obj);
            obj = pg.CreateObject(113, "CopyData", DateTime.Now.AddDays(567), 234234234);
            list.Add(obj);
            obj = pg.CreateObject(114, "SomeData", DateTime.Now.AddDays(443), 234234234);
            list.Add(obj);
            obj = pg.CreateObject(115, "URData", DateTime.Now.AddDays(765), 234234234);
            list.Add(obj);
            obj = pg.CreateObject(116, "OurData", DateTime.Now.AddDays(987), 234234234);
            list.Add(obj);
            obj = pg.CreateObject(117, "HisData", DateTime.Now.AddDays(333), 234234234);
            list.Add(obj);
            obj = pg.CreateObject(118, "HerData", DateTime.Now.AddDays(23), 234234234);
            list.Add(obj);
            obj = pg.CreateObject(119, "MyData", DateTime.Now.AddDays(24), 234234234);
            list.Add(obj);
            obj = pg.CreateObject(120, "AllData", DateTime.Now.AddDays(34), 234234234);
            list.Add(obj);
            EntityApp app = new EntityApp(list);
            var data = app.SortByName();
            foreach(var entity in data)
            {
                Console.WriteLine($"{entity.Id} has data as {entity.StringData}");
            }
        }
    }
}
