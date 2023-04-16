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
    internal class ModelCreateRoom
    {
        private NpgsqlConnection connection;

        public ModelCreateRoom(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable GetFacilities()
        {
            DataTable facilities = new DataTable();
            string query = "select * from facilities where type_of_facilities IN ('Загальне', 'Кімната')";
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
        public List<string> GetHotels()
        {
            List<string> hotels = new List<string>();
            string query = "select name from hotels";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                        hotels.Add(reader.GetString(0));
                }
            }
            return hotels;
        }
        public string CreateNewRoom(string name, string roomGrade, string meals, string photo, string info, string period, int price, List<string> facilities)
        {
            string query = $"SELECT id_hotel FROM hotels WHERE name = '{name}'";
            int hotelID = 0;
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            hotelID = reader.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            query = $"INSERT INTO rooms (id_hotel, room_grade, meals, period_of_residence, info, photos, price)" +
                $" VALUES({hotelID}, '{roomGrade}', '{meals}', '{period}', '{info}', '{photo}', {price}) RETURNING id_room";
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
                query = $"SELECT AddFacilities('{facilities[i]}', {id}, 'Кімната')";
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
