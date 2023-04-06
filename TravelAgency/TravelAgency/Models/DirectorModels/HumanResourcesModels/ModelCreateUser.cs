using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    internal class ModelCreateUser
    {
        private NpgsqlConnection connection;
        public string ErrorMess { get; set; }

        public ModelCreateUser(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public int CreateUser(int TalonNum, string password) 
        {
            string query = $"CALL create_new_agent({TalonNum}, '{password}')";
            using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection)) 
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    ErrorMess = ex.Message;
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
            return 1;
        }
    }
}
