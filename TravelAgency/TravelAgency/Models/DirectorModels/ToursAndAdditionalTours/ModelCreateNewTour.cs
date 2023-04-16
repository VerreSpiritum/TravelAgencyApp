using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;

namespace TravelAgency.Models.DirectorModels.ToursAndAdditionalTours
{
    internal class ModelCreateNewTour
    {
        private NpgsqlConnection connection;
        private GetInfoAbout cities;
        public string Error { get; set; }

        public ModelCreateNewTour(NpgsqlConnection connection)
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
            
        public void InsertIntoTour(Dictionary<string, object> text, DataTable cit)
        {
            int id = 0;
            Error = "";
            string query = $"INSERT INTO tour VALUES (DEFAULT, '{text["Operator"]}', '{text["TypeOfTour"]}', '{text["Name"]}', " +
                $"'{text["Date_of_departure"]}', {text["CountOfNights"]}, {text["CountOfChildren"]}, '{text["Transfer"]}', " +
                $"'{text["Booking"]}', '{text["Photos"]}', {text["Price"]}, {text["CountOfAvailTour"]}, {text["numberOfAdd"]}, " +
                $"'{text["DepCity"]}') RETURNING id_tour";
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

            InsertIntoCIT(cit, id);
        }

        public void InsertIntoCIT(DataTable cit, int id)
        {
            Error = "";
            foreach(DataRow row in cit.Rows)
            {
                string query = $"INSERT INTO cities_included_in_tour VALUES " +
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
