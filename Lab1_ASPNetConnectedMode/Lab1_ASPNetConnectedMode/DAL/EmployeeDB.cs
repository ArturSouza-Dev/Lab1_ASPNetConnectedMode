using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Lab1_ASPNetConnectedMode.BLL;

namespace Lab1_ASPNetConnectedMode.DAL
{
    public class EmployeeDB
    {        
        public static void SaveRecord(Employee emp)
        {
            using(SqlConnection conn = UtilityDB.ConnectDB())
            {
                string saveQuery = "INSERT INTO Employees VALUES(@EmployeeId, @FirstName, @LastName, @JobTitle)";
                SqlCommand cmd = new SqlCommand(saveQuery, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
                cmd.ExecuteNonQuery();
                conn.Close();
            }                       
        }

        public static List<Employee> GetAllEmployees() 
        {
            List<Employee> empList = new List<Employee>();
            using(SqlConnection conn = UtilityDB.ConnectDB())
            {
                Employee emp;                
                string displayAllQuery = "SELECT * FROM dbo.Employees";
                SqlCommand cmd = new SqlCommand(displayAllQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emp = new Employee();
                    emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.JobTitle = reader["JobTitle"].ToString();
                    empList.Add(emp);
                }
            }            
            return empList;
        }

        public static Employee SearchRecord(int id)
        {
            Employee emp = new Employee();
            using (SqlConnection conn = UtilityDB.ConnectDB()) 
            {
                string searchRecordQuery = "SELECT * FROM dbo.Employees WHERE Employee.Id = @EmployeeId";
                SqlCommand cmd = new SqlCommand(searchRecordQuery, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader != null)
                {                    
                    emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.JobTitle = reader["JobTitle"].ToString();                    
                }
            }
            return emp;
        }

        public static List<Employee> SearchRecord(string name)
        {
            List<Employee> empList = new List<Employee>();
            using(SqlConnection conn = UtilityDB.ConnectDB())
            {
                string searchRecordQuery = "SELECT * FROM dbo.Employees WHERE (FirstName = @FirstName) OR (LastName = @LastName)";
                SqlCommand cmd = new SqlCommand(searchRecordQuery, conn);
                cmd.Parameters.AddWithValue("@FirstName", name);
                cmd.Parameters.AddWithValue("@LastName", name);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader != null) 
                {
                    Employee emp = new Employee();
                    emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.JobTitle = reader["JobTitle"].ToString();
                    empList.Add(emp);
                }
            }
            return empList;
        }

        public static int UpdateRecord(string id, string fName = null, string lName = null, string jTitle = null)
        {
            string insertRecordQuery = "UPDATE dbo.Employees SET ";            

            using(SqlConnection conn = UtilityDB.ConnectDB())
            {       
                SqlCommand cmd = new SqlCommand();

                if (fName != null)
                {
                    insertRecordQuery += "FirstName = @FirstName ";
                    cmd.Parameters.AddWithValue("@FirstName", fName);
                }
                if (lName != null)
                {
                    insertRecordQuery += "LastName = @LastName ";
                    cmd.Parameters.AddWithValue("@LastName", lName);
                }
                if (jTitle != null)
                {
                    insertRecordQuery += "JobTitle = @JobTitle ";
                    cmd.Parameters.AddWithValue("@JobTitle", jTitle);
                }

                insertRecordQuery += "WHERE EmployeeId = @EmployeeId";
                cmd.Parameters.AddWithValue("@EmployeeId", id);

                cmd.Connection = conn;
                cmd.CommandText = insertRecordQuery;
                return cmd.ExecuteNonQuery();                
            }
        }

        public static void DeleteRecord(string id)
        {
            string deleteRecordQuery = ""
        }
    }
}