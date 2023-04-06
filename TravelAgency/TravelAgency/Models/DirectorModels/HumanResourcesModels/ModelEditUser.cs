using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    internal class ModelEditUser
    {
        private NpgsqlConnection connection;

        public ModelEditUser(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public void ChangePassword(string login, string password)
        {
            string query = $"ALTER ROLE {login} WITH PASSWORD '{password}'";

            using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection)) 
            {
                try
                {
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
