using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Collections.Generic;
using System.Data;

namespace WebApplication9.Models
{
    public class EmployeeDataAccess
    {
        DBConnection Dbconnection;
        public EmployeeDataAccess()
        {
            Dbconnection = new DBConnection();
        }
        public List<Employee> GetEmployee()
        {
            string Sp = "SP_Employee";
            SqlCommand sql = new SqlCommand(Sp, Dbconnection.connection);
            if (Dbconnection.connection.State == ConnectionState.Closed)
            {
             Dbconnection.connection.Open();
            }
            SqlDataReader dr = sql.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while (dr.Read())
            {
                Employee Emp = new Employee();
                Emp.id=(int)dr["id"];
            }
        }
    }
}
