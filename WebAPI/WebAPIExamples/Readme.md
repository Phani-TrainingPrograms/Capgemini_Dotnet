# Steps for creating a Web API Project
1. Create a new .NET CORE ASP.NET Web API Project from the MS Visual Studio.
2. Accept the defailts, make sure U have checked for Not using Top level Statements and Add Controllers.
3. Create a folder called Models and define UR Properties in it.
4. Add the following Nuget packages
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```
5. Create the ApplicationDbContext and implement the code as shared in the Repo.
6. Modify the appsettings.json with the proper connectionstring. Refer the appsettings.json config file
7. Build the Project and run the following Commands:
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```
8. Check for the newly created tables in the Server Explorer.
9. Create a Controller Class and select API->Empty Controller and provide a name with Suffix Controller
10. Implement the class with reference to the code shared.
11. Provide the DI feature in the Program.cs file. Refer the file in the Repo.
12. Build the Application.
13. Test it with Swagger or Post man 
