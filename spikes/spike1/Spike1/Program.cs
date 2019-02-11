using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Spike1
{
    class Program
    {

        const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\Noah\OneDrive - University of Wisconsin - Platteville\UW-Platteville\Senior Year\S18\Intermediate SE\Group A4 Repo\spikes\spike1\TestDatabase.accdb";

        const string dbTable = "TestTable";

        static void Main(string[] args)
        {
            InsertQuery(16, 18, "InsertMe");
            //DeleteQuery(16);
            //SelectQuery();
        }

        private static void InsertQuery(int myID, int testNum, string myComment) // Pass in the table
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            string query = $"INSERT INTO {dbTable} VALUES (@ID, @TestNum, @Comment)";

            connection.Open();

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", myID);
                command.Parameters.AddWithValue("@TestNum", testNum);
                command.Parameters.AddWithValue("@Comment", myComment);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static void DeleteQuery(int myID) // Pass in the table
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = connectionString;
            string query = $"DELETE FROM {dbTable} WHERE ID = {myID}";
            //string query = $"DELETE FROM {dbTable} WHERE Comment = '{myComment}'"; // For strings

            connection.Open();

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static void SelectQuery() // Pass in the table
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = connectionString;
            string query = $"SELECT * FROM {dbTable} WHERE ID > 50";

            connection.Open();

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                OleDbDataReader reader = command.ExecuteReader();
                foreach (var value in reader)
                {
                    int i = 7; // dummy placeholder
                }
                connection.Close();
            }
        }

    }
}
