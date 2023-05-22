using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.DirectorModels.TransportsAndTransfersModels
{
    internal class ModelCreateNewTransport
    {
        private NpgsqlConnection connection;

        public string Error { get; set; }
        public int CountOfSeats { get; set; }

        public ModelCreateNewTransport(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable GetFacilites()
        {
            DataTable facilities = new DataTable();

            string query = "SELECT name FROM Facilities WHERE type_of_facilities IN ('Загальне', 'Транспорт')";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        facilities.Load(reader);
                }
            }
            return facilities;

        }
        public void CreateNewTransport(string name, string shortinfo, string production_date, int seats, string photo, List<string> facilities)
        {
            Error = string.Empty;
            int id = 0;
            string query = "INSERT INTO transport VALUES " +
                $"(DEFAULT, '{name}', '{shortinfo}', '1/1/{production_date}', {seats}, '{photo}')" +
                $" RETURNING id_transport;";
            using(NpgsqlCommand cmd = new NpgsqlCommand( query, connection))
            {
                try
                {
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                            id = reader.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return;
                }
            }
            if(facilities.Count > 0)
            {
                for (int i = 0; i < facilities.Count; i++)
                {
                    query = $"SELECT AddFacilities('{facilities[i]}', {id}, 'Транспорт')";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
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
                            return;
                        }
                    }
                }
            }
            
        }
    }
}
