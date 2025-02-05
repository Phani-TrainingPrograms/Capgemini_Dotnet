using DbFirstApproach.Models;
/*
 * create a new Console App with .NET CORE
 * Add the nuget packages: EFCore.SQLserver, EFCore.Design, EFCore.Tools
 * Run the Scaffold-DbContext with appropriate args
 * This command shall generate the classes and the DBContext
 * Discard the unused classes and its references in the Code.
 * Perform the CRUD operations on the existing classes. 
 */
namespace DbFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new CapgeminiDbContext();
            var records = context.EmpTables.ToList();
            foreach(var record in records)
            {
                Console.WriteLine(record.EmpName);
            }
        }
    }
    //Scaffold-DbContext "Server=PHANI-PC\SQLEXPRESS;Database=CapgeminiDb;Trusted_Connection=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
}
