using System;
using System.Collections.Generic;
using System.Text;
using System.Windows; //Messagebox
using MySql.Data.MySqlClient;
using System.Data;

namespace Vorlage_Klausur
{
    class DB_Connection
    {
        // Connectionstring
        //example "server=127.0.0.1;uid=root;pwd=;database=test";

        private string connString = "server=127.0.0.1;uid=root;pwd=;database=tododb";

        private MySqlConnection connection;
        public DB_Connection()
        {
            connection = new MySqlConnection(connString);
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void WriteData(string qry)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand(qry, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable ReadData(string qry)
        {
            DataTable dt = new DataTable();
            connection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(qry, connection);
            da.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
