using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.DirectorModels.TransportsAndTransfersModels
{
    internal class ModelEditTransfer
    {
        private GetInfoAboutAvailableTransportsCities classToGetInfo;
        private NpgsqlConnection connection;
        private List<object> list = new List<object>();

        public List<string> AvailableTransport { get; set; }
        public List<string> AvailableDepartureCity { get; set; }
        public List<string> AvailableCityToVisit { get; set; }

        public List<object> InfoTable { get => list; set => list = value; }
        public string Error { get; set; }

        public ModelEditTransfer(NpgsqlConnection connection)
        {
            this.connection = connection;
            classToGetInfo = new GetInfoAboutAvailableTransportsCities(connection);
        }
        public int GetInfoFormA(int ID)
        {
            string query = $"SELECT name, from_where, to_where, price FROM show_transfers WHERE id_transfer = {ID}";
            bool checkRows;
            list = new List<object>();
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(0));
                            list.Add(reader.GetString(1));
                            list.Add(reader.GetString(2));
                            list.Add(reader.GetDouble(3));
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
            return 1;
        }
        public void GetInfo()
        {
            AvailableTransport = classToGetInfo.GetListOfAvailbleTransports();
            if (AvailableTransport == null)
            {
                Error = classToGetInfo.Error;
            }
            AvailableDepartureCity = classToGetInfo.GetListOfCity(true);
            if (AvailableDepartureCity == null)
            {
                {
                    Error = classToGetInfo.Error;
                }
            }
            AvailableCityToVisit = classToGetInfo.GetListOfCity(false);
            if (AvailableCityToVisit == null)
            {
                Error = classToGetInfo.Error;
            }
        }

        public int CreateNewTransfer(Dictionary<string, object> data, int ID)
        {
            string query = $"SELECT id_transport FROM transport WHERE transport.name = '{data["Name"]}'";
            int IDtransport = 0;

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IDtransport = reader.GetInt32(0);
                    }
                }

            }
            string a = Convert.ToString(data["Cost"]).Replace(',', '.');
            query = $"UPDATE transfer SET id_transport = {IDtransport}, from_where = '{data["fromWhere"]}', to_where = '{data["toWhere"]}', price = {a } WHERE id_transfer = {ID}";
            
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return 0;
                }

            }
            return 1;
        }
    
}
}
