using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;

namespace TravelAgency.Models.DirectorModels.HotelsAndRooms
{
    internal class ModelEditRoom
    {
        private NpgsqlConnection connection;
        public string name { get; set; }
        public string roomGrade { get; set; }
        public string meals { get; set; }
        public string photo { get; set; }
        public string info { get; set; }
        public string period { get; set; } 
        public int price { get; set; }

        public ModelEditRoom(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public List<string> GetInfoAboutRooms()
        {
            List<string> data = new List<string>();
            string query = "select name || ' - ' || id_room from rooms r, hotels h where r.id_hotel = h.id_hotel";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                        data.Add(reader.GetString(0));
                }
            }
            return data;
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

        public void GetLastRoomInfo(int ID)
        {
            string query = $"SELECT room_grade, meals, period_of_residence, info, photos, price FROM rooms WHERE id_room = {ID}";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roomGrade = reader.GetString(0);
                            meals = reader.GetString(1);
                            period = reader.GetString(2);
                            info = reader.GetString(3);
                            photo = reader.GetString(4);
                            price = reader.GetInt32(5);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
        public List<string> GetFacilitiesInRoom(int ID)
        {
            string query = $"SELECT f.name FROM facilities f, facilities_in_room fit, rooms t WHERE f.id_facilities = fit.id_facilities" +
               $" AND t.id_room = fit.id_room  AND t.id_room = {ID}";
            List<string> temp = new List<string>();
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            temp.Add(reader.GetString(0));

                        }
                    }
                    else
                    {
                        //checkRows = false;
                    }
                    reader.Close();
                }
            }

            return temp;
        }

        public string EditRoom(string name, string roomGrade, string meals, string photo, string info, string period, int price, List<string> facilities, int ID)
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
            query = $"UPDATE rooms SET id_hotel = '{hotelID}', room_grade = '{roomGrade}', meals = '{meals}', period_of_residence = '{period}', info = '{info}', photos = '{photo}', price = {price} WHERE id_room = {ID}";
            using(NpgsqlCommand cmd = new NpgsqlCommand( query, connection))
            {
                try
                {
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            if (facilities != null)
            {
                for (int i = 0; i < facilities.Count; i++)
                {
                    int fID = 0;

                    string queryTransportFacilities = $"select fit.id_facilities from facilities_in_room fit, facilities f " +
                        $"WHERE fit.id_facilities = f.id_facilities AND fit.id_room = {ID} AND f.name = '{facilities[i]}'";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(queryTransportFacilities, connection))
                    {
                        try
                        {
                            using (NpgsqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                    fID = reader.GetInt32(0);
                            }
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                    }
                    if (fID > 0)
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand($"DELETE FROM facilities_in_room WHERE id_facilities = {fID} AND id_room = {ID}", connection))
                        {
                            try
                            {
                                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                        fID = reader.GetInt32(0);
                                }
                            }
                            catch (Exception ex)
                            {
                                return ex.Message;
                            }
                        }
                    }
                    else
                    {
                        queryTransportFacilities = $"select id_facilities from facilities f " +
                            $"WHERE  f.name = '{facilities[i]}'";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(queryTransportFacilities, connection))
                        {
                            try
                            {
                                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                        fID = reader.GetInt32(0);
                                }
                            }
                            catch (Exception ex)
                            {
                                return ex.Message;
                            }
                        }
                    }
                    if (fID > 0)
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO facilities_in_room VALUES ({ID}, {fID})", connection))
                        {
                            try
                            {
                                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                        fID = reader.GetInt32(0);
                                }
                            }
                            catch (Exception ex)
                            {
                                return ex.Message;
                            }
                        }
                    }

                }
            }
            return "";
        }
    }
}
