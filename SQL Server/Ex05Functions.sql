--Examples for working with Date and Time----

--Functions in SQL can be used as Expressions of a SQL statement which cannot be done using stored proc. 
PRINT GETDATE()

Create Function CreateDate(@date date)
RETURNS varchar(50)
AS
BEGIN
declare @retval varchar(50)
set @retval = '' + CAST(Day(@date) as varchar(5)) + '/' + Cast(MONTH(@date) as varchar(5))+ '/' + Cast(YEAR(@date) as varchar(7))
RETURN @retval
END

Print dbo.CreateDate(GetDate())

Create Function GetAge(@Dob Date)
RETURNS INT
AS
BEGIN
DECLARE @age int
SET @age = DATEDIFF(year, @dob, GETDATE())
RETURN @age
END

SELECT dbo.GetAge('01/12/1976')

----table value functions(TVFs)--------------
Alter Function GetEmployeesByCity(@city varchar(50))
RETURNS TABLE
AS
RETURN (SELECT * FROM EMPTABLE WHERE EmpAddress LIKE '%' +  @city + '%')

Select EmpName, EmpAddress from dbo.GetEmployeesByCity('um')