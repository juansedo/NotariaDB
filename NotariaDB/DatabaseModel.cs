using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using MySql.Data.MySqlClient;

namespace NotariaDB
{

    class DatabaseModel
    {
        protected static string connection = @"Server=localhost,3306;User=root;Password=;Database=testing";

        public static void Initialize()
        {
            using(var db = new MySqlConnection(connection))
            {
                var sql = "SELECT * FROM first_table";
                var result = db.Query<Person>(sql);

                System.Diagnostics.Debug.WriteLine("Reading data! Beep, boop, beep");
                foreach(var i in result)
                {
                    System.Diagnostics.Debug.WriteLine(i.name);
                }
            }
        }
    }

    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
