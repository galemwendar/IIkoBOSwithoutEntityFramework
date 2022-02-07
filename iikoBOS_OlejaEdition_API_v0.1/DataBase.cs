using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

                SqliteCommand command = new SqliteCommand("CREATE TABLE IF NOT EXISTS Servers(ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, URL TEXT UNIQUE NULL, ServerVersion TEXT UNIQUE NULL, ServerEdition TEXT UNIQUE NULL, ServerName TEXT UNIQUE NULL, Name TEXT UNIQUE  NULL)", connection);
     
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

                SqliteCommand command = new SqliteCommand("SELECT DISTINCT ID, URL, ServerVersion, ServerEdition, ServerName, Name  FROM Servers", connection);

                using (SqliteDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            row = new string[]
                            {
                                Convert.ToString(dataReader["ID"]),
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
                        //MessageBox.Show("Таблица не имеет ни одной строки");
                    }
                    return rows;
                }

            }
        }
        public List<string[]> GetFiltredServers(string filterstring)
        {
            List<string[]> rows = new List<string[]>();
            List<string[]> filtredrows = new List<string[]>();
            string[] row = null;

            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand("SELECT DISTINCT ID, URL, ServerVersion, ServerEdition, ServerName, Name  FROM Servers", connection);

                using (SqliteDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            row = new string[]
                            {
                                Convert.ToString(dataReader["ID"]),
                                Convert.ToString(dataReader["URL"]),
                                Convert.ToString(dataReader["ServerVersion"]),
                                Convert.ToString(dataReader["ServerEdition"]),
                                Convert.ToString(dataReader["ServerName"]),
                                Convert.ToString(dataReader["Name"])

                            };
                            rows.Add(row);
                        }
                    }
                }

                filtredrows = rows.Where((x) => x[5].ToLower().Contains(filterstring.ToLower())).ToList();
                return filtredrows;
            }
        }

        public void InsertServerProperties(string mUrl, string serverVersion, string serverEdition, string serverName)
        {
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"INSERT OR IGNORE INTO Servers (URL,ServerVersion,ServerEdition,serverName) VALUES('{mUrl}','{serverVersion}','{serverEdition}','{serverName}')", connection);
                command.ExecuteNonQuery();

            }

            
        }
    }
}
