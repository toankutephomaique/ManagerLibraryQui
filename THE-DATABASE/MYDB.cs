using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanlythuvienDHCNQN.THE_DATABASE
{
    // open xampp
    // create the database
    // create table user
    // add the mysql connector

    class MYDB
    {

        // the connection
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharp_lms_db");

        // create a function to open the connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // create a function to return the connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        // create a function to return a table of data
        // parameter = the parameters of the query
        public DataTable getData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        // create a function to set data and execute a query
        public int setData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            openConnection();

            int commandState = command.ExecuteNonQuery();

            closeConnection();

            return commandState;
        }
    }
}