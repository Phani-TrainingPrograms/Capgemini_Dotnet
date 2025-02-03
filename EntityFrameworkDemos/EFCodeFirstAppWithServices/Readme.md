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

### Create a new folder called Services
- Create a new Class called BookAuthorService which contains the functions that abstract the EF Code for the Console Application.
- Service classes are consumed by the UI Applications without bothering about the source of the data.
- Service Class has the same functions as the Repository Class and it simply contains the Interface Component and calls the functions after appropriately applying the Business logic.
