using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConexionBD
{
    class Connection
    {

        private string serverName;
        private string serverPort;
        private string dbName;
        private string userName;
        private string password;
        SqlConnection connex;

        public string ServerName { get => serverName; set => serverName = value; }
        public string ServerPort { get => serverPort; set => serverPort = value; }
        public string DbName { get => dbName; set => dbName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public SqlConnection Connex { get => connex; set => connex = value; }

        public Connection(string serverName = "200.234.224.123", string serverPort = "54321", string dbName = "ChristianEmployees", 
            string userName = "sa", string password = "Sql#123456789")
        {
            this.serverName = serverName;
            this.serverPort = serverPort;
            this.dbName = dbName;
            this.userName = userName;
            this.password = password;
            string ConnectionString =
               "data source=" + serverName + "," + serverPort + ";" +
               "initial catalog=" + dbName + ";" +
               "user id=" + userName + ";" +
               "password=" + password + ";" +
               "MultipleActiveResultSets=True;" +
               "Encrypt=True;Connection Timeout=60;" +
               "TrustServerCertificate = True";
            this.Connex = new SqlConnection(ConnectionString);

        }
        public void Open()
        {
            try
            {
                Connex.Open();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void Close()
        {
            try
            {
                Connex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

    }
}   
        

