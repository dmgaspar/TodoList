using System;
using MySql.Data.MySqlClient;


namespace MySqlProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //server = localhost; port = 3306; User Id = root; password = 'Vamos@@2'; database = todo_list

            //string cs = @"server=localhost;userid=dbuser;password=s$cret;database=testdb";
            string cs = @"server=localhost;userid=root;password=Vamos@@2;database=todo_list";

            using var con = new MySqlConnection(cs);
            con.Open();

            Console.WriteLine($"MySQL version : {con.ServerVersion}");
        }
    }
}
