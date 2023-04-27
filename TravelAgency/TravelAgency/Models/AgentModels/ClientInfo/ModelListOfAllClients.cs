using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TravelAgency.Models
{
    internal class ModelListOfAllClients
    {
        private NpgsqlConnection connection;
        private string query;

        public ModelListOfAllClients(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable GetInfoAboutCustomer()
        {
            DataTable clientInfo = new DataTable();
            query = $"SELECT * FROM listOfAllClients";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        clientInfo.Load(reader);
                }
            }
            
            return clientInfo;
        }

        public int DeleteCustomer(int id)
        {
            int checkError;
            query = $"DELETE FROM customer WHERE id_client = {id}";
            using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                checkError = Convert.ToInt32(cmd.ExecuteNonQuery().ToString());
            }
            return checkError;
        }
    }
}
