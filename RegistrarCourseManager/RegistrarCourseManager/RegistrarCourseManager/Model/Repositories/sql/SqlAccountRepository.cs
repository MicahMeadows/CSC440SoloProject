using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarCourseManager.Model.Repositories.sql
{
    public class SqlAccountRepository : IAccountRepository
    {
        string connectionString = "";

        public SqlAccountRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Authenticate(Account user)
        {
            string query = "SELECT * FROM account WHERE username = @username AND password = @password";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.Password);

            connection.Open();

            List<Account> accList = new List<Account>();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString("username");
                string password = reader.GetString("password");
                accList.Add(new Account(username, password));
            }

            return accList.Any(acc => acc.Equals(user));
        }
    }
}
