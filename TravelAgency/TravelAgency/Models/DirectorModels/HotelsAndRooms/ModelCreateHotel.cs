using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;

namespace TravelAgency.Models.DirectorModels.HotelsAndRooms
{
    internal class ModelCreateHotel
    {
        private NpgsqlConnection connection;
        private GetInfoAbout info;

        public ModelCreateHotel(NpgsqlConnection connection)
        {
            this.connection = connection;
            info = new GetInfoAbout(connection);
        }

        public DataTable GetFacilities()
        {
            DataTable facilities = new DataTable();
            string query = "select * from facilities where type_of_facilities IN ('Загальне', 'Готель')";
            using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using(NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.HasRows)
                        facilities.Load(reader);
                }
            }
            return facilities;
        }

        public List<string> GetCity()
        {
            return info.GetListOfCity(false);
        }

        public string CreateNewHotel(string name, string category, string city, string location, string photo, string checkIn, string checkOut, List<string> facilities)
        {
            string query = $"INSERT INTO hotels (name, hotel_category, city, check_in, check_out, photos, city_location)" +
                $" VALUES('{name}', '{category}', '{city}', '{checkIn}', '{checkOut}', '{photo}', '{location}') RETURNING id_hotel";
            int id = 0;

            using(NpgsqlCommand cmd = new NpgsqlCommand( query, connection))
            {
                try
                {
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            id = reader.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

            for(int i = 0; i < facilities.Count; i++)
            {
                query = $"SELECT AddFacilities('{facilities[i]}', {id}, 'Готель')";
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
                        return ex.Message;
                    }
                }
            }

            return "";
        }
    }
}
