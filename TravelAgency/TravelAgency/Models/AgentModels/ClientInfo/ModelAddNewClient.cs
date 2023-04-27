using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.AgentModels.ClientInfo
{
    internal class ModelAddNewClient
    {
        private NpgsqlConnection connection;

        public ModelAddNewClient(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public string InsertIntoTable(string name, string patronymic, string surname, string gender, string phoneNumber, 
            string email, string date, string registryEntry, string idCode, string PassportNum)
        {
            string Error = "";
            string query = $"INSERT INTO customer VALUES (DEFAULT, '{name}', '{surname}', '{patronymic}', '{gender}', '{phoneNumber}', '{email}'," +
                $"'{date}', '{registryEntry}', '{idCode}', '{PassportNum}')";
            using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                }

            }
            return Error;
        }
    }
}
