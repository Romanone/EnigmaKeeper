using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EnigmaKeeper.Password;

namespace EnigmaKeeper.BL
{
    class  DB_StorageController
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;
        private readonly IPassword _password;

        public DB_StorageController()
        {
            connection = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            reader = cmd.ExecuteReader();
            _password = new ConcretePassword();
        }

        static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=EnigmaKeeper; Integrated Security=True";

        

        private void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch { }
        }

        private void Command()
        {
            cmd.Connection = connection;
            cmd.CommandText = "Some comm";

            while (reader.Read())
            {
                _password.Name = reader.GetString(1);
                _password.Login = reader.GetString(2);
                _password.Password = reader.GetString(3);
                _password.Encrypted = reader.GetBoolean(4);
            }

            _password.AddPassword(_password.Name, _password.Login, _password.Password, _password.Encrypted);
        }
        
    }
}
