Select * from EmpTable
Select * from DeptTable

Select * from Emptable where EmpAddress = 'Bangalore'

Select * from Emptable where EmpAddress = 'Bangalore' And EmpSalary > 35000
--------------Sql Server Scalar Value functions-------
Select Max(EmpSalary) as MaxSal from Emptable
Select Min(EmpSalary) as MinSal from Emptable
Select Avg(EmpSalary)  as AvgSal from Emptable

Select Max(EmpSalary) as MaxSal, Min(EmpSalary) as MinSal, Avg(EmpSalary) as AvgSal from EmpTable
--SVFs are used to extract single values from the Query. U can create UR own SVFs for UR frequently performed Queries. 
Select Top(20) EmpName, EmpAddress from EmpTable 
WHERE EmpSalary > 40000

Select Top 50 PERCENT * from Emptable
Select Count(EmpName) as EmpCount from EMptable
---todo: Get the bottom 50% of Employees from the table
-----------Join Statements---------------
Select EmpTable.EmpId, EmpTable.EmpName, DeptTable.DeptName from EmpTable Join DeptTable 
On EmpTable.DeptId = DeptTable.DeptId
--This is called as Equi-Join as it allows to get common data based on the matching condition that evaluates to equality. 
--Right join: Gets all the data from the right table and common data of the Left Table. 
--Now the Emptable has certain records that are not associated with any Dept. 
Insert into EmpTable(EmpId, EmpName, EmpAddress, EmpSalary) values(106, 'ShyamSunder', 'Chennai', 40000)
Insert into EmpTable(EmpId, EmpName, EmpAddress, EmpSalary) values(102, 'Radha', 'Hyderabad', 35000)
Insert into EmpTable(EmpId, EmpName, EmpAddress, EmpSalary) values(103, 'Latha', 'Pune', 34000)
Insert into EmpTable(EmpId, EmpName, EmpAddress, EmpSalary) values(104, 'Geetha', 'Hyderabad', 24000)
Insert into EmpTable(EmpId, EmpName, EmpAddress, EmpSalary) values(105, 'Rita', 'Pune', 43000)

--Left Join: Coalesce is a Function used to replace the values for a given column where it has null. 
Select EmpTable.*, COALESCE(DeptTable.DeptName, 'Not Set')  from EmpTable 
left Join DeptTable 
on Emptable.DeptId = DeptTable.DeptId

--Right Join: it combines the common data of the left table and also the unique data from the right table. 
Select Emptable.*, DeptTable.DeptName from EmpTable
Right join DeptTable 
on EmpTable.DeptId = DeptTable.DeptId
--------------------------Group By----------------------------
--Find the Count of Employees for each city. 
Select Max(EmpSalary) as MaxSalary, Min(EmpSalary) As MinSalary,  EmpAddress From EmpTable
Group by EmpAddress  order by MaxSalary desc
--Group by clause's select section must have either aggregate function or the column names and should be the part of the group by block 
--Display total salaries for each city. 
Select Sum(EmpSalary) as TotalSalaries, EmpAddress from EmpTable
Group by EmpAddress order by TotalSalaries Desc
---Nested Queries----------------
--get a list of employees whose salary is more than the avg salary in their city. 

Select e.empname, e.empaddress, e.empsalary, avg_salaries.avgSalary as AvgSalary 
From Emptable e
JOIN
(
	Select EmpAddress, Avg(EmpSalary) as avgSalary
	From Emptable Group by EmpAddress
) As avg_salaries On e.EmpAddress = avg_salaries.EmpAddress
Where e.EmpSalary > avg_salaries.avgSalary

