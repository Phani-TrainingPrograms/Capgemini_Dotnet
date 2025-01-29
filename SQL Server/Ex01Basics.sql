--SQL Server is the database developed by MS for handling large amount of data using SQL. 
--Structured Query Language(Sql) is the common language used for most of the database programming. 
-- SSMS(Sql Server mangagement studio) is the tool for working with SQL server. It is the IDE for SQL server. 
-- SSMS allows to perform most of the operations using the IDE itself. However, for better readability and working experience, it is recommended to perform the interactions using SQL(Queries).
-- SQL comes with variations based on the vendor of the database. MS sql is called as Transact SQL(T-SQL), Oracle's SQL is called PL-SQL. Much of the features are common but for few keywords and terms. 
-- How to create and drop a database
-- How to create and drop a Table
Drop table EmpTable
Drop table Dept
Create table EmpTable
(
	EmpId int primary kEy,
	EmpName nvarchar(50) NOT NULL, 
	EmpAddress nvarchar(50)NOT NULL,
	EmpSalary money NOT NULL
)

Create table DeptTable
(
	DeptId int primary key identity(1,1), --U should not pass the value
	DeptName varchar(50) NOT NULL
)

insert into DeptTable values('Training')
insert into DeptTable values('Development')
insert into DeptTable values('Sales')
insert into DeptTable values('Admin')

Select * from DeptTable
--Adding a new column to the Existing table which shall reference another table. It means that the data for this column should be any of the values from the referenced column.
Alter table Emptable
Add DeptId int 
references DeptTable(DeptId)
sp_tables
-- How to add a column to an existing table
-- How to drop a column in the existing table.
-- How to add relation with a table column(references 

insert into EmpTable values(6, 'JoyDip Mondal', 'Kolkata', 35000, 1)
insert into EmpTable values(2, 'Murali Shetty', 'Tumkur', 45000, 2)
insert into EmpTable values(3, 'Ramnath Nishad', 'Lucknow', 40000, 3)
insert into EmpTable values(4, 'Vinod Kumar', 'Shimoga', 30000, 1)
insert into EmpTable values(5, 'Banu Prakash', 'Bangalore', 45000, 1)

---Inserting values to specific columns of the table
insert into EmpTable (EmpId, EmpName, EmpAddress, EmpSalary) values(7, 'Surender', 'Hyderabad', 50000)
Drop table DeptTable
Alter table EmpTable
Add constraint FK_EmpTable_DeptId
alter table Emptable drop column deptId --drop the column

truncate table EmpTable --deletes all the records of the table. 
--Commands for DDL : Create, Drop, Alter, Truncate. 
Select * from EmpTable