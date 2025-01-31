# Code First Approach in .NET CORE App
1. Create a Console Core Project
2. Include the following nuget packages:
=> Install-Package Microsoft.EntityFrameworkCore
=> Install-Package Microsoft.EntityFrameworkCore.SqlServer
=> Install-Package Microsoft.EntityFrameworkCore.Tools

3. Create the Model class and the DBContext Class: The code is available below.
4. Run the Commands from the Packate Manager Console:
```
	add-migration migrationName-version
	update-database
```
5. Build the Application, notice the DB server will have the tables created accordingly.
Complete the below code	
