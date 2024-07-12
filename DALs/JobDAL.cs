using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBD.Models;

namespace ConexionBD.DALs
{
    public class JobDAL
    {
        Connection conn = new Connection();

        public List<Job> GetJob()
        {
            List<Job>? jobs = new List<Job>();
            try
            {
                string query = "SELECT * FROM dbo.jobs";
                SqlCommand command = new SqlCommand(query, conn.Connex);
                conn.Open();
                SqlDataReader records = command.ExecuteReader();

                while (records.Read())
                {
                    int job_id = records.GetInt32(0);
                    string job_title = records.GetString(1);
                    decimal min_salary = records.GetDecimal(2);
                    decimal max_salary = records.GetDecimal(3);

                    Job jobGet = new Job(job_id, job_title, min_salary, max_salary);
                    jobs?.Add(jobGet);
                }

                records.Close();
                conn.Close();
                return jobs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


    }
}
