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


alter table Emp add Gender Char(1) , Phone_Number varchar(10) , Address varchar(100) , Department varchar(100) , Basic_Pay decimal(10,2) , Deduction decimal(10,2) , Taxable_Pay decimal(10,2) , Income_Tax decimal(10,2) , Net_Pay decimal(10,2); 