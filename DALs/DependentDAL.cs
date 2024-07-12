using ConexionBD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD.DALs
{
    class DependentDAL
    {
        Connection conn = new Connection();

        public List<Dependent> GetDependent()
        {
            List<Dependent>? dependents = new List<Dependent>();
            try
            {
                string query = "SELECT * FROM dbo.dependents";
                SqlCommand command = new SqlCommand(query, conn.Connex);
                conn.Open();
                SqlDataReader records = command.ExecuteReader();
                while (records.Read())
                {
                    int dependent_id = records.GetInt32(0);
                    string first_name = records.GetString(1);
                    string last_name = records.GetString(2);
                    string relationship = records.GetString(3);
                    int employee_id = records.GetInt32(4);

                    Dependent dependentGet = new Dependent(dependent_id, first_name, last_name, relationship, employee_id);
                    dependents?.Add(dependentGet);
                }

                records.Close();
                conn.Close();

                return dependents;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
