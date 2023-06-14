using System;
using System.Data.SqlClient;

namespace PayRoll_Services
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            //Server Name = (localdb)\MSSQLLocalDB
            //Authentication = Windows
            //Database Name = EmployeeDB

            //Create, update, retrieve, abd delete records from the multiple tables in the database.
            //Connect your C# code to database
            //Send your SQL queries

            Console.WriteLine("Welcome to Payroll Services");

            //Connection

            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Database = EmployeeDB; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //Insert Operation - Create 
            string query = "insert into Emp values ('Avani' , 40000 , '2020-10-24' , 'F' , '9340593778' , 'Delhi' , 'Head' , 15000 , 0 , 0 , 0 , 0)";
            SqlCommand insertCommand = new SqlCommand(query, connection);
            insertCommand.ExecuteNonQuery();
            
            //Update Operation
            string updateQuery = @"update Emp set Salary = 3000000 where Emp_ID = 7";
            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.ExecuteNonQuery();
           
            // Calculate the sum of salaries
            string sumQuery = "select Sum(Salary) from Emp";
            SqlCommand sumCommand = new SqlCommand(sumQuery, connection);
            decimal sum = (decimal)sumCommand.ExecuteScalar();
            Console.WriteLine("Sum of Salaries: " + sum);
            

            // Calculate the average salary
            string avgQuery = "SELECT Avg(Salary) FROM Emp";
            SqlCommand avgCommand = new SqlCommand(avgQuery, connection);
            decimal average = (decimal)avgCommand.ExecuteScalar();
            Console.WriteLine("Average Salary: " + average);
            
            // Find the minimum and maximum salary            
            SqlCommand minMaxCommand = new SqlCommand("SELECT MIN(Salary), MAX(Salary) FROM Emp", connection);
            SqlDataReader reader = minMaxCommand.ExecuteReader();
            if (reader.Read())
            {
                decimal minSalary = (decimal)reader[0];
                decimal maxSalary = (decimal)reader[1];
                Console.WriteLine("Minimum Salary: " + minSalary);
                Console.WriteLine("Maximum Salary: " + maxSalary);
            }
            reader.Close();
                         
            // Count the number of male and female employees
            string maleCountQuery = "select Count(*) from Emp where Gender = 'M'";
            SqlCommand countMaleCommand = new SqlCommand(maleCountQuery, connection);
            int maleCount = (int)countMaleCommand.ExecuteScalar();
            Console.WriteLine("Number of Male Employees: " + maleCount);

            string femaleCountQuery = "select Count(*) from Emp where Gender = 'F'";
            SqlCommand countFemaleCommand = new SqlCommand(femaleCountQuery, connection);
            int femaleCount = (int)countFemaleCommand.ExecuteScalar();
            Console.WriteLine("Number of Female Employees: " + femaleCount);
            
            connection.Close();
        }
    }
}
