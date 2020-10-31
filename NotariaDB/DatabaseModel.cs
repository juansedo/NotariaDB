using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using MySql.Data.MySqlClient;

namespace NotariaDB
{

    class DatabaseModel
    {
        public string Connection { get; private set; }

        public DatabaseModel(string db_name, string server = "localhost", string port = "3306", string user = "root", string password = "")
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

        public void UpdateSheets(/*NacSheet ns, MatSheet ms, DefSheet df,*/ UserSheet us)
        {
            using var DBConnection = new MySqlConnection(Connection);
            
            var sql_user = "SELECT id, d.description AS doctype, name, surname, expedition_place, expedition_date, birth_date FROM usuarios u JOIN doctypes d USING (doctype_id)";
            var result_users = DBConnection.Query<User>(sql_user);

            us.Rows.Clear();
            foreach (var user in result_users)
                us.AddRow(user);
        }

    }


    public class User
    {
        public int Id { get; set; }
        public string Doctype { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Expedition_place { get; set; }
        public string Expedition_date { get; set; }
        public string Birth_date { get; set; }
    }
}
