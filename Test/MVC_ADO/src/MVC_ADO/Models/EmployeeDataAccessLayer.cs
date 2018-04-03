using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ADO.Models
{
    public class EmployeeDataAccessLayer
    {
        string connectionString = "Put Your Connection string here";

        //To View all employees details    
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> lstemployee = new List<Employee>();

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6ALAO3UQ\SAPNA;Initial Catalog=Test;User ID=sa;Password=123"))
            {
                SqlCommand cmd = new SqlCommand("select * from tblEmployee", con);
               // cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employee employee = new Employee();

                    employee.id = Convert.ToInt32(rdr["ID"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.Password = rdr["Password"].ToString();
                    employee.PhoneNumber = Convert.ToInt64(rdr["PhoneNumber"]);
                    employee.Address = rdr["Address"].ToString();

                    lstemployee.Add(employee);
                }
                con.Close();
            }
            return lstemployee;
        }

        //To Add new employee record    
        public void AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6ALAO3UQ\SAPNA;Initial Catalog=Test;User ID=sa;Password=123"))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblEmployee VALUES(@Name, @Email, @Password, @PhoneNumber, @Address);", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", employee.id);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("@Address", employee.Address);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Update the records of a particluar employee  
        public void UpdateEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6ALAO3UQ\SAPNA;Initial Catalog=Test;User ID=sa;Password=123"))
            {
                SqlCommand cmd = new SqlCommand("Update tblEmployee set Name=@Name, Email=@Email, Password=@Passowrd, PhoneNumber=@PhoneNumber, Address=@Address where id"+employee.id+";", con);
               // cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("@Address", employee.Address);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Get the details of a particular employee  
        public Employee GetEmployeeData(int? id)
        {
            Employee employee = new Employee();

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6ALAO3UQ\SAPNA;Initial Catalog=Test;User ID=sa;Password=123"))
            {
                string sqlQuery = "SELECT * FROM tblEmployee WHERE id= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    employee.Name = rdr["Name"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.Password = rdr["Password"].ToString();
                    employee.PhoneNumber = Convert.ToInt64(rdr["PhoneNumber"]);
                    employee.Address = rdr["Address"].ToString();
                }
            }
            return employee;
        }

        //To Delete the record on a particular employee  
        public void DeleteEmployee(int? id)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6ALAO3UQ\SAPNA;Initial Catalog=Test;User ID=sa;Password=123"))
            {                
                SqlCommand cmd = new SqlCommand("delete from tblEmployee where @id", con);
               // cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
