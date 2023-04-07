using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.DirectorModels.TransportsAndTransfersModels
{
    internal class GetInfoAboutAvailableTransportsCities
    {
        private NpgsqlConnection connection;
        private string error;

        public string Error { get => error; }

        public GetInfoAboutAvailableTransportsCities(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public List<string> GetListOfAvailbleTransports()
        {
            error = "";
            List<string> data = new List<string>();
            string query = "SELECT * FROM availableTransportsList";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            data.Add(reader.GetString(0));
                        }
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
            return data;
        }

        public List<string> GetListOfCity(bool IsDeparture)
        {
            error = "";
            List<string> data = new List<string>();
            string query = "SELECT * FROM cities WHERE city_type IN"; 
            query += IsDeparture ?" ('Відправка', 'Змішане');": " ('Відвідування', 'Змішане');";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(reader.GetString(0));
                        }
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
            return data;
        }
    }
}
