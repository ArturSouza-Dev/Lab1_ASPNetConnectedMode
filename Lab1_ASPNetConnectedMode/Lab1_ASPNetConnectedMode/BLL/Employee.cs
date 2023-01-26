using Lab1_ASPNetConnectedMode.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1_ASPNetConnectedMode.BLL
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }

        public void SaveEmployee()
        {
            EmployeeDB.SaveRecord(this);
        }

        public List<Employee> GetEmployees()
        {
            return EmployeeDB.GetAllEmployees();
        }

        public void SearchEmployee(int id)
        {
            EmployeeDB.SearchRecord(id);
        }
        public void SearchEmployees(string name)
        {
            EmployeeDB.SearchRecord(name);
        }
        public int UpdateEmployee(string id, string fName = null, string lName = null, string jTitle = null)
        {
            return EmployeeDB.UpdateRecord(id, fName = null, lName = null, jTitle = null);
        }
        public override string ToString()
        {
            return $"Employee ID: {this.EmployeeId}\n" +
                   $"FirstName: {this.FirstName}\n" +
                   $"LastName: {this.LastName}\n" +
                   $"JobTitle {this.JobTitle}.";
        }
    }
}