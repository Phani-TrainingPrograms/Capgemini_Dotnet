--Stored Procedures are sp pre parsed functions that are created for frequently executing SQL commands. This will help in optimization of the SQL statements that are executed frequently, making it work like a function and makes the execution faster. 
--Variables required for the Stored Procs are declared with prefix @.
Create Procedure AddEmp
(
	@id int,
	@name varchar(50), 
	@address varchar(50),
	@salary money,
	@deptId int
)
AS
INSERT INTO Emptable values(@id, @name, @address, @salary, @deptId)

-----------------Calling the Procedure----
EXEC [dbo].AddEmp
	@id = 123,
	@name = 'Robert',
	@address = 'Mumbai',
	@salary = 40000,
	@deptId = 3
GO

Select * from EmpTable where Empid = 123

Create Procedure AddDept
(
	@deptName varchar(50),
	@deptId int OUTPUT
) 
AS 
Insert into DeptTable values(@deptName)
SET @deptId = @@IDENTITY
--@@IDENTITY is the variable of SQL Server that provides the auto generated Id if the insertion is successfull.
-----Calling the stored procedure-----
DECLARE	@deptId int

EXEC	[dbo].AddDept
		@deptName = 'SuperGroup',
		@deptId = @deptId OUTPUT

SELECT	@deptId as NewDept
GO

SElect Count(*) from DeptTable
