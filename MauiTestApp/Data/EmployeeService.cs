using MauiTestApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.Data
{
    public class EmployeeService
    {
        public List<EmployeeModel> EmployeeDetails()
        {
            List<EmployeeModel> employeeModelList = new List<EmployeeModel>()
            {
                new EmployeeModel() {FirstName = "Avi", LastName = "Teach", Designation = "Teacher", StartDate = DateTime.Now, Salary = 500},
                new EmployeeModel() {FirstName = "Sid", LastName = "Stud", Designation = "Student", StartDate = DateTime.Parse("10/04/2021"), Salary = 500},
                new EmployeeModel() {FirstName = "Him", LastName = "Lect", Designation = "Lecturer", StartDate = DateTime.Parse("11/05/2020"), Salary = 500},
                new EmployeeModel() {FirstName = "Her", LastName = "Stud", Designation = "Student", StartDate = DateTime.Parse("12/14/2012"), Salary = 500},
                new EmployeeModel() {FirstName = "Sam", LastName = "Teach", Designation = "Teacher", StartDate = DateTime.Parse("01/23/2019"), Salary = 500},
            };

            return employeeModelList;
        }

        public List<EmployeeModel> GetEmployeeData(string name)
        {
            var employeeList = EmployeeDetails();

            var designation = employeeList.Where(x => x.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            return designation;
        }
    }
}
