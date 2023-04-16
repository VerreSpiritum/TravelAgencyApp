using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;

namespace TravelAgency.Models.DirectorModels.HotelsAndRooms
{
    internal class ModelEditHotel
    {
        private NpgsqlConnection connection;
        private GetInfoAbout info;

        public string Name { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Photo { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }

        public ModelEditHotel(NpgsqlConnection connection)
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
        public List<int> GetID()
        {
            string query = "select id_hotel from hotels";
            List<int> list = new List<int>();
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(reader.GetInt32(0));
                    }
                }
            }
            return list;
        }
        public void GetInfo(int ID)
        {
            string query = $"SELECT name, hotel_category, city, check_in, check_out, photos, city_location FROM hotels WHERE id_hotel = {ID}";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Name = reader.GetString(0);
                            Category = reader.GetString(1);
                            City= reader.GetString(2);
                            CheckIn = reader.GetTimeSpan(3).ToString();
                            CheckOut= reader.GetTimeSpan(4).ToString();
                            Photo = reader.GetString(5);
                            Location = reader.GetString(6);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
        public List<string> GetFacilitiesInHotel(int ID)
        {
            string query = $"SELECT f.name FROM facilities f, facilities_in_hotel fit, hotels t WHERE f.id_facilities = fit.id_facilities" +
               $" AND t.id_hotel = fit.id_hotel  AND t.id_hotel = {ID}";
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
        public string UpdateHotel(string name, string category, string city, string location, string photo, string checkIn, string checkOut, List<string> facilities, int ID)
        {
            string query = $"UPDATE hotels SET name = '{name}', hotel_category = '{category}', city = '{city}', check_in = '{checkIn}', check_out = '{checkOut}', photos = '{photo}', city_location = '{location}'" +
                $"WHERE id_hotel = {ID}";

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

                    string queryTransportFacilities = $"select fit.id_facilities from facilities_in_hotel fit, facilities f " +
                        $"WHERE fit.id_facilities = f.id_facilities AND fit.id_hotel = {ID} AND f.name = '{facilities[i]}'";

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
                        using (NpgsqlCommand cmd = new NpgsqlCommand($"DELETE FROM facilities_in_hotel WHERE id_facilities = {fID} AND id_hotel = {ID}", connection))
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
                        using (NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO facilities_in_hotel VALUES ({ID}, {fID})", connection))
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
