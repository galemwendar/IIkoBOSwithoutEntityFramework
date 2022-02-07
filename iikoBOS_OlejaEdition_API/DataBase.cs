using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iikoBOS_prealpha_API
{
    public class DataBase
    {
        const string ConnectionString = "Data Source = data.db";
        public bool CreateTable()
        {
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXISTS Servers (id INTEGER NOT NULL PRIMARY KEY," +
                    " URL TEXT NOT NULL" +
                    " ServerVersion TEXT NOT NULL" +
                    " ServerEdition TEXT NOT NULL" +
                    " ServerName TEXT NOT NULL" +
                    " Name TEXT NOT NULL" +
                    ")", connection);
                command.ExecuteNonQuery();
                command = new SqliteCommand("SELECT COUNT(*) FROM sqlite_master WHERE TYPE='TABLE' AND NAME='Servers'", connection);
                using (SqliteDataReader dataReader = command.ExecuteReader())
                {
                    return dataReader.HasRows;
                }
            }
        }


        public List<string[]> GetServers()
        {
            List<string[]> rows = new List<string[]>();
            string[] row = null;

            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand("SELECT id, Name FROM Servers", connection);

                using (SqliteDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            row = new string[]
                            {
                                Convert.ToString(dataReader["URL"]),
                                Convert.ToString(dataReader["ServerVersion"]),
                                Convert.ToString(dataReader["ServerEdition"]),
                                Convert.ToString(dataReader["ServerName"]),
                                Convert.ToString(dataReader["Name"])

                            };
                            rows.Add(row);
                        }


                    }
                    else
                    {
                        MessageBox.Show("Таблица не имеет ни одной строки");
                    }
                    return rows;
                }

            }
        }

        public void InsertServerProperties(string mUrl, string serverVersion, string serverEdition, string serverName)
        {
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"INSERT INTO Servers (URL,ServerVersion,ServerEdition,ServerName )" +
                    $" VALUES ('{mUrl}','{serverVersion}','{serverEdition}','{serverName}')", connection);
                command.ExecuteNonQuery();

            }

            
        }
    }
}
