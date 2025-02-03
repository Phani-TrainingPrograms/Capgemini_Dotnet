## Project structure:
- Entities -> Contain the Models for the Application
- Data -> Contains the DbContext and Migrations related to it. 
- Repos-> Contains the interfaces and implementations for the data access
- Services-> Contains the Business logic and service layers. 
- ConsoleApp-> The Main App that consumes the services using Dependency Injection(DI)

### Create a Console App .NET CORE Project
Add the following Nuget Packages:
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

### Create a new folder called Entities and create UR Entity classes there. 
- Create a new folder  called Data and write UR DbContext class in it. 
- Build the Application. 
- Run the following commands in the Package manager Command Window:
- add-migration mig1
- update-database ->Shall generate the required tables in the backend.

### Create a new folder called Repos->Repository Layer. 
- Create an IBookRepository, IAuthorRepository interfaces and its implementor classes. 
- Implement the Classes for the CRUD operations required. 
