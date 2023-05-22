using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;

namespace TravelAgency.Models.DirectorModels.ToursAndAdditionalTours
{
    internal class ModelEditTour
    {
        private NpgsqlConnection connection;
        private GetInfoAbout cities;
        public string Error { get; set; }

        public ModelEditTour(NpgsqlConnection connection)
        {
            this.connection = connection;
            cities = new GetInfoAbout(connection);
        }

        public List<string> GetCity(bool IsDepCity)
        {
            if (IsDepCity)
                return cities.GetListOfCity(true);
            else
                return cities.GetListOfCity(false);
        }
        public List<object> GetLastInfo(int ID)
        {
            string query = "SELECT name, operator, photos, departure_city, date_of_departure, number_of_adults, number_of_children, transfer, advance_booking, price from tour " +
                $"WHERE id_tour = {ID}";
            List<object> temp = new List<object>();
            Error = String.Empty;
            
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                temp.Add(reader.GetString(0));
                                temp.Add(reader.GetString(1));
                                temp.Add(reader.GetString(2));
                                temp.Add(reader.GetString(3));
                                temp.Add(reader.GetDateTime(4));
                                temp.Add(reader.GetInt32(5));
                                temp.Add(reader.GetInt32(6));
                                temp.Add(reader.GetString(7));
                                temp.Add(reader.GetString(8));
                                temp.Add(reader.GetInt32(9));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                }
            }
            return temp;
        }
        public DataTable GetLastInfoInTourCity(int ID)
        {
            string query = $"SELECT city, start_date, end_date FROM cities_included_in_tour WHERE id_tour = {ID}";
            DataTable temp = new DataTable();
            Error = String.Empty;
            
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                            temp.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                }
            }
            return temp;
        }
        public List<object> GetListOfTourNum()
        {
            string query = "SELECT id_tour FROM tour";
            List<object> result = new List<object>();

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            result.Add(reader.GetInt32(0));
                    }
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                }
            }
            return result;
        }
        public void UpdateIntoTour(Dictionary<string, object> text, DataTable cit, int ID)
        {
            int id = 0;
            Error = "";
            string query = $"UPDATE tour SET operator = '{text["Operator"]}', name = '{text["Name"]}', " +
                $"date_of_departure = '{text["Date_of_departure"]}', number_of_nights = {text["CountOfNights"]}, number_of_children = {text["CountOfChildren"]}, transfer = '{text["Transfer"]}', " +
                $"advance_booking = '{text["Booking"]}', photos = '{text["Photos"]}', price = {text["Price"]}, number_of_adults = {text["numberOfAdd"]}, " +
                $"departure_city = '{text["DepCity"]}' WHERE id_tour = {ID}";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection)) 
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            id = reader.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return;
                }
            }

            InsertIntoCIT(cit, ID);
        }

        public void InsertIntoCIT(DataTable cit, int id)
        {
            Error = "";
            string query = $"DELETE FROM cities_included_in_tour WHERE id_tour = {id}";
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
            foreach (DataRow row in cit.Rows)
            {

                query = $"INSERT INTO cities_included_in_tour VALUES " +
                $"(DEFAULT, {id}, '{row["cityName"]}', '{row["startD"]}', '{row["endD"]}')";

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
