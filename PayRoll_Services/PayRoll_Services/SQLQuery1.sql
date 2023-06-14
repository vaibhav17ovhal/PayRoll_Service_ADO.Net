Create Database EmployeeDB
use EmployeeDB

Create table Emp 
(
	Emp_ID int primary key identity(1,1),
	Emp_Name varchar(100) not null,
	Salary decimal(10,2),
	Starting_date Date
);

--CURD Operation - Create , Update , View and Delete
Select * from Emp;


