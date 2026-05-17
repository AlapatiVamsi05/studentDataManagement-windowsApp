using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dbops_sql
{
    internal class db
    {
        public static string connectionString =
            "server=localhost;port=3306;database=student;uid=root;pwd=root123;";
        public static MySqlConnection connection  = new MySqlConnection(connectionString);

        public static void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occurred while accessing database");
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred while exiting database");
            }
        }

    }
}