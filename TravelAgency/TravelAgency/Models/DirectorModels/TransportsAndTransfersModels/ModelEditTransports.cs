using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TravelAgency.Models.DirectorModels.TransportsAndTransfersModels
{
    internal class ModelEditTransports
    {
        private NpgsqlConnection connection;
        private List<string> temp = new List<string>();

        public int ID { get; set; }
        public string Error { get; set; }
        public List<object> infoToShow{get; set;}
        public List<string> Facilities { get => temp; set => temp = value; }

        public DataTable facilites { get; set; }

        public ModelEditTransports(NpgsqlConnection connection)
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

        public int GetInfo(int ID)
        {
            string query = $"SELECT * FROM transport WHERE id_transport = {ID}";
            bool checkRows;
            infoToShow = new List<object>();
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            infoToShow.Add(reader.GetString(1));
                            infoToShow.Add(reader.GetString(2));
                            infoToShow.Add(reader.GetDateTime(3).Year.ToString());
                            infoToShow.Add(reader.GetInt32(4));
                            infoToShow.Add(reader.GetString(5));
                            
                        }
                        checkRows = true;
                    }
                    else
                    {
                        checkRows = false;
                    }
                    reader.Close();
                }
            }

            query = $"SELECT f.name FROM facilities f, facilities_in_transport fit, transport t WHERE f.id_facilities = fit.id_facilities" +
                $" AND t.id_transport = fit.id_transport  AND t.id_transport = {ID}";
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
                        checkRows = true;
                    }
                    else
                    {
                        //checkRows = false;
                    }
                    reader.Close();
                }
            }

            return checkRows ?1:0;

        }
        public int UpdateInfo(Dictionary<string, object> info, Dictionary<string, bool> Facilities, int ID)
        {
            int resOfWorking = 1;
            Error = null;
            foreach(string key in info.Keys)
            {
                string queryTransport = $"UPDATE transport SET " + CreateQueryWithInfo(info, key) + $" WHERE id_transport = {ID}";
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryTransport, connection))
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
                        return 0;
                    }
                }
            }
            if (Facilities != null)
            {
                foreach (string key in Facilities.Keys)
                {
                    int fID = 0;
                    if (!Facilities[key])
                    {
                        string queryTransportFacilities = $"select fit.id_facilities from facilities_in_transport fit, facilities f " +
                            $"WHERE fit.id_facilities = f.id_facilities AND fit.id_transport = {ID} AND f.name = '{key}'";

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
                                Error = ex.Message;
                                return 0;
                            }
                        }
                        if (fID > 0)
                        {
                            using (NpgsqlCommand cmd = new NpgsqlCommand($"DELETE FROM facilities_in_transport WHERE id_facilities = {fID} AND id_transport = {ID}", connection))
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
                                    Error = ex.Message;
                                    return 0;
                                }
                            }
                        }

                    }
                    else
                    {
                        string queryTransportFacilities = $"select id_facilities from facilities f " +
                            $"WHERE  f.name = '{key}'";

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
                                Error = ex.Message;
                                return 0;
                            }
                        }
                        if (fID > 0)
                        {
                            using (NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO facilities_in_transport VALUES ({ID}, {fID})", connection))
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
                                    Error = ex.Message;
                                    return 0;
                                }
                            }
                        }
                    }
                }
            }
            return 1;
        }
        private string CreateQueryWithFacilities(Dictionary<string, bool> info, string key)
        {
            string query = "";

            return "";
        }
        private string CreateQueryWithInfo(Dictionary<string, object> info, string key)
        {
            switch (key)
            {
                case "Name": return $"name = '{info[key]}'";
                case "ShortInfo": return $"about_transport = '{info[key]}'";
                case "ReleaseDate": return $"year_of_production = '01/01/{info[key]}'";
                case "CountOfSeats": return $"number_of_seats = {info[key]}";
                case "LinkPhoto": return $"photo = '{info[key]}'";
            }
            return "";
        }
    }
}
