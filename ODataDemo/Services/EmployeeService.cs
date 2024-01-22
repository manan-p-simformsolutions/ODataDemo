using ODataDemo.Models;
using System.Collections.Generic;

namespace ODataDemo.Services
{
    public class EmployeeService
    {
        private List<Employee> Employees;

        public EmployeeService()
        {
            Employees = new List<Employee>();
            CreateData();
        }
        public List<Employee> CreateData()
        {
            Employees.Add(new Employee { Id = 1, Name = "Jay", Role = "Developer", City = "Hyderabad", Pincode = 360001, Salary = 55000, DateOfBirth = new DateTime(1990, 5, 15) });
            Employees.Add(new Employee { Id = 2, Name = "Raj", Role = "Developer", City = "Bangalore", Pincode = 382010, Salary = 60000, DateOfBirth = new DateTime(1999, 7, 22) });
            Employees.Add(new Employee { Id = 3, Name = "Bobby", Role = "Developer", City = "Chennai", Pincode = 360001, Salary = 65000, DateOfBirth = new DateTime(2000, 2, 21) });
            Employees.Add(new Employee { Id = 4, Name = "Praveen", Role = "Developer", City = "Rajkot", Pincode = 382010, Salary = 70000, DateOfBirth = new DateTime(1992, 1, 01) });
            Employees.Add(new Employee { Id = 5, Name = "Naresh", Role = "Developer", City = "Surat", Pincode = 360001, Salary = 75000, DateOfBirth = new DateTime(2000, 9, 11) });
            Employees.Add(new Employee { Id = 6, Name = "Yateesh", Role = "Developer", City = "Gandhinagar", Pincode = 500077, Salary = 80000, DateOfBirth = new DateTime(1992, 8, 30) });
            Employees.Add(new Employee { Id = 7, Name = "Priyanka", Role = "Developer", City = "Rajkot", Pincode = 500064, Salary = 85000, DateOfBirth = new DateTime(1992, 6, 25) });
            Employees.Add(new Employee { Id = 8, Name = "Jisha", Role = "QA", City = "Gandhinagar", Pincode = 500078, Salary = 90000, DateOfBirth = new DateTime(2000, 5, 20) });
            Employees.Add(new Employee { Id = 9, Name = "Aravind", Role = "QA", City = "Gandhinagar", Pincode = 500214, Salary = 25000, DateOfBirth = new DateTime(1994, 3, 22) });
            Employees.Add(new Employee { Id = 10, Name = "Meera", Role = "QA", City = "Surat", Pincode = 360001, Salary = 30000, DateOfBirth = new DateTime(1995, 1, 26) });
            Employees.Add(new Employee { Id = 11, Name = "Simran", Role = "QA", City = "Rajkot", Pincode = 500534, Salary = 35000, DateOfBirth = new DateTime(1999, 5, 28) });
            Employees.Add(new Employee { Id = 12, Name = "Samir", Role = "QA", City = "Mumbai", Pincode = 500654, Salary = 40000, DateOfBirth = new DateTime(1994, 5, 24) });
            Employees.Add(new Employee { Id = 13, Name = "Vihaan", Role = "QA", City = "Vadodara", Pincode = 5000765, Salary = 45000, DateOfBirth = new DateTime(1992, 1, 20) });
            Employees.Add(new Employee { Id = 14, Name = "Rocky", Role = "QA", City = "Mumbai", Pincode = 5000224, Salary = 50000, DateOfBirth = new DateTime(1990, 12, 21) });
            Employees.Add(new Employee { Id = 15, Name = "Nihaan", Role = "QA", City = "Mangalore", Pincode = 500965, Salary = 55000, DateOfBirth = new DateTime(1996, 10, 19) });
            Employees.Add(new Employee { Id = 16, Name = "Aarav", Role = "Developer", City = "Surat", Pincode = 394107, Salary = 60000, DateOfBirth = new DateTime(1998, 5, 20) });
            Employees.Add(new Employee { Id = 17, Name = "Anaya", Role = "Developer", City = "Ahmedabad", Pincode = 380001, Salary = 65000, DateOfBirth = new DateTime(1995, 10, 16) });
            Employees.Add(new Employee { Id = 18, Name = "Parth", Role = "QA", City = "Rajkot", Pincode = 360001, Salary = 70000, DateOfBirth = new DateTime(2001, 11, 14) });
            Employees.Add(new Employee { Id = 19, Name = "Bharat", Role = "QA", City = "Vadodara", Pincode = 390001, Salary = 75000, DateOfBirth = new DateTime(1998, 11, 15) });
            Employees.Add(new Employee { Id = 20, Name = "Kiran", Role = "QA", City = "Gandhinagar", Pincode = 382010, Salary = 80000, DateOfBirth = new DateTime(2000, 12, 18) });
            return Employees;
        }
        public List<Employee> GetEmployees() => Employees.ToList();

    }
}
