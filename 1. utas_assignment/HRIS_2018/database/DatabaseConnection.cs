using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HRIS.database
{
    class DatabaseConnection
    {
        // four constants used for connecting to mysql
        private const string DB_Name = "kit206";
        private const string DB_Username = "kit206";
        private const string DB_Password = "kit206";

        private const string DB_Server = "alacritas.cis.utas.edu.au";
        //private const string DB_Server = "localhost";
        //private const string DB_Server = "alacritas.cis.utas.edu.au";

        private MySqlCommand cmd;
        private MySqlDataReader rdr;

        // declare two variables for mysql connection
        public MySqlConnection conn;


        //constructor : initialize the mysql connection
        public DatabaseConnection()
        {
            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3};connection timeout=3;SslMode=none", DB_Name, DB_Server, DB_Username, DB_Password);
            conn = new MySqlConnection(connectionString);

        }

        public DataTable DB_Execute(string sql_statement)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                cmd = new MySqlCommand(sql_statement, conn);
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return dt;
        }
    }
}
