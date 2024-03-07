using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine($"Sum: {numbers.Sum()}");

            //TODO: Print the Average of numbers

            Console.WriteLine($"Average: {numbers.Average()}");

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("List in Ascending Order:");
            numbers.OrderBy(x => x).ToList().ForEach(x => { Console.WriteLine(x); });

            //TODO: Order numbers in descending order and print to the console

            Console.WriteLine("\nList in Descending Order:");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => { Console.WriteLine(x); });

            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("\nNumbers in the list > 6:");
            numbers.Where(x => x > 6).ToList().ForEach(x => { Console.WriteLine(x); });

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("First 4 of 10 numbers in Ascending Order:");
            numbers.OrderBy(x => x).Take(4).ToList().ForEach(x => { Console.WriteLine(x); });

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            numbers.SetValue(55, 4);
            Console.WriteLine("\nUpdated List in Descending Order:");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => { Console.WriteLine(x); });

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("\nList of Employees with First Name starts with 'C' or 'S':");
            employees.Where(x => Char.ToUpper(x.FirstName[0]) == 'C' || Char.ToUpper(x.FirstName[0]) == 'S').OrderBy(x => x.FirstName).ToList().ForEach(x =>  Console.WriteLine(x.FullName));

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("\nList of Employees Older than 26 sorted by Age, FirstName:");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"Name: {x.FullName}\t\tAge: {x.Age}"));

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("\nSum of YOE for Employees Older than 35 and YOE <= 10:");
            Console.WriteLine(employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Sum(x => x.YearsOfExperience));

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("\nAverage YOE for Employees Older than 35 and YOE <= 10:");
            Console.WriteLine(employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Average(x => x.YearsOfExperience));

            //TODO: Add an employee to the end of the list without using employees.Add()

            Console.WriteLine("Number of Employees BEFORE new Employee Add:");
            Console.WriteLine(employees.Count);
            employees = employees.Append(new Employee("Greg", "Wanner", 55, 1)).ToList();
            Console.WriteLine("Number of Employees AFTER new Employee Add:");
            Console.WriteLine(employees.Count);
            Console.WriteLine("List of Current Employees:");
            employees.OrderBy(x => x.LastName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            //Select(x => { x.FirstName = "Greg"; x.LastName = "Wanner"; x.YearsOfExperience = 1; x.Age = 55; }).ToList();

            //Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
