using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using MySql.Data.MySqlClient;
using NotariaDB.Entities;

namespace NotariaDB
{

    class DatabaseModel
    {
        public string Connection { get; private set; }

        public DatabaseModel(string db_name = "notariadb", string server = "localhost", string port = "3306", string user = "root", string password = "")
        {
            Connection = $"Server={server},{port};";
            Connection += $"User={user};";
            Connection += $"Password={password};";
            Connection += $"Database={db_name}";
        }

        public void Initialize()
        {
            using var DBConnection = new MySqlConnection(Connection);

            var sql = "SELECT id, d.description AS doctype, name, surname, expedition_place, expedition_date, birth_date FROM usuarios u JOIN doctypes d USING (doctype_id)";
            var result = DBConnection.Query<User>(sql);
            
            foreach (var i in result)
            {
                System.Diagnostics.Debug.WriteLine(i.Name + " tiene " + i.Doctype + " con número " + i.Id);
            }
        }

        //public System.Data.DataTable query<T>(string sql_string)
        //{
        //    using var DBConnection = new MySqlConnection(Connection);

        //    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        //    dataAdapter.SelectCommand = new MySqlCommand(sql_string, DBConnection);
        //    System.Data.DataTable dt = new System.Data.DataTable();
        //    dataAdapter.Fill(dt);
        //    return dt;
        //}

    }


    
}
