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
    internal class ModelEditAddTour
    {
        private NpgsqlConnection connection;
        private GetInfoAbout cities;
        public string Error { get; set; }

        public ModelEditAddTour(NpgsqlConnection connection)
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
            string query = "SELECT operator, type_of_tour, name, date_of_departure, number_of_children, transfer, info, price, number_of_adults, departure_city from additional_tour " +
                $"WHERE id_additional_tour = {ID}";
            List<object> temp = new List<object>();

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
                                temp.Add(reader.GetDateTime(3));
                                temp.Add(reader.GetInt32(4));
                                temp.Add(reader.GetString(5));
                                temp.Add(reader.GetString(6));
                                temp.Add(reader.GetInt32(7));
                                temp.Add(reader.GetInt32(8));
                                temp.Add(reader.GetString(9));

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
            string query = $"SELECT city, start_date, end_date FROM cities_included_in_additional_tour WHERE id_additional_tour = {ID}";
            DataTable temp = new DataTable();

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
            string query = "SELECT id_additional_tour FROM additional_tour";
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
            string query = $"UPDATE additional_tour SET operator = '{text["Operator"]}', type_of_tour = '{text["TypeOfTour"]}', name = '{text["Name"]}', " +
                $"date_of_departure = '{text["Date_of_departure"]}', number_of_children = {text["CountOfChildren"]}, transfer = '{text["Transfer"]}', " +
                $" info = '{text["Info"]}', price = {text["Price"]}, number_of_adults = {text["numberOfAdd"]}, " +
                $"departure_city = '{text["DepCity"]}' WHERE id_additional_tour = {ID}";

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
            string query = $"DELETE FROM cities_included_in_additional_tour WHERE id_additional_tour = {id}";
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

                query = $"INSERT INTO cities_included_in_additional_tour VALUES " +
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
