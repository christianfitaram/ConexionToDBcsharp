using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD.Models;

namespace ConexionBD.DALs
{
    public class EmployeeDAL
    {
        Connection conn = new Connection();
        public EmployeeDAL()
        {

        }
        public void InsertEmployee()
        {
            try
            {
                string query = "INSERT INTO dbo.employees" +
                "(first_name,last_name,email,phone_number,hire_date,job_id,salary,manager_id,department_id) " +
                "VALUES (@first_name,@last_name,@email,@phone_number,@hire_date,@job_id,@salary,@manager_id,@department_id)";

                SqlCommand command = new SqlCommand(query, conn.Connex);
                conn.Open();
                command.Parameters.AddWithValue("@first_name", "Nombre");
                command.Parameters.AddWithValue("@last_name", "Apellido");
                command.Parameters.AddWithValue("@email", "email@mailserver.com");
                command.Parameters.AddWithValue("@phone_number", "666666666");
                command.Parameters.AddWithValue("@hire_date", "2020/06/06");
                command.Parameters.AddWithValue("@job_id", 3);
                command.Parameters.AddWithValue("@salary", 2000);
                command.Parameters.AddWithValue("@manager_id", 114);
                command.Parameters.AddWithValue("@department_id", 3);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public List<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                string query = "SELECT * FROM dbo.employees";
                SqlCommand command = new SqlCommand(query, conn.Connex);
                conn.Open();
                SqlDataReader records = command.ExecuteReader();
                while (records.Read())
                {
                    int employee_id = records.GetInt32(0);
                    string first_name = records.GetString(1);
                    string last_name = records.GetString(2);
                    string email = records.GetString(3);
                    string? phone_number = records.IsDBNull(4) ? null : records.GetString(4);
                    DateTime hire_date = records.GetDateTime(5);
                    int job_id = records.GetInt32(6);
                    decimal salary = records.GetDecimal(7);
                    int? manager_id = records.IsDBNull(8) ? null : records.GetInt32(8);
                    int? deparment_id = records.IsDBNull(8) ? null : records.GetInt32(8);

                    Employee employeeGet = new Employee(employee_id, first_name, last_name, email, phone_number,
                        hire_date, job_id, salary, manager_id, deparment_id);
                    employees?.Add(employeeGet);
                }

                records.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return employees;
        }

    }
}
