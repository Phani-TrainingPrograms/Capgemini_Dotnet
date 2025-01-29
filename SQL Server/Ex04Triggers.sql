--Triggers are like events(Actions) that are invoked automatically when a certain condition is met(insert, delete, update). 

Create table Customer
(
CstId int primary key identity(1,1),
CstName varchar(50) not null,
CstAddress varchar(100) not null, 
BillDate Date default GetDate(),
BillAmount money
)

Create Table Customer_Audit
(
 Id int primary key identity(1,1),
 desctiption varchar(200) NOT NULL
)

-----------Insertion Trigger------------
Create trigger OnNewCustomer
ON Customer
For INSERT
AS
BEGIN
DECLARE @id int
Select @id = CstId from inserted
Declare @desc varchar(200)
Declare @name varchar(50)
Select @name = CstName from inserted 
set @desc = 'Customer with Id ' + Cast(@id as varchar(4)) + ' and name ' + @name + ' is inserted successfully'
Insert into Customer_Audit values(@desc)
END

--------------Update Trigger----------------
Create trigger OnUpdateCustomer
ON CUSTOMER FOR UPDATE
AS
BEGIN
	DECLARE @id int
	DECLARE @oldName varchar(50)
	DECLARE @newName varchar(50)
	SELECT @id = CstId from inserted
	SELECT @newName = CstName from inserted
	SELECT @oldName = CstName from deleted
	Insert into Customer_Audit values('The customer with Id ' + CAST(@id as varchar(3)) + ' has been updated with a new Name ' + @newName + ' from the old Name ' + @oldName)
END

Update Customer Set CstName = 'Phani Raj B.N.' where CstId = 1


insert into Customer(CstName, CstAddress, BillAmount) values('Phaniraj', 'Bangalore', 4500)

-- todo: Implement the deletion trigger for delete on Customer. 