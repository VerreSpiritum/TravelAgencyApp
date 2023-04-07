using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TravelAgency.Models.DirectorModels.TransportsAndTransfersModels
{
    internal class ModelCreateNewTransfer
    {
        private GetInfoAboutAvailableTransportsCities classToGetInfo;
        private NpgsqlConnection connection;
        private List<string> infoToShow;

        public List<string> AvailableTransport { get; set; }
        public List<string> AvailableDepartureCity { get; set; }
        public List<string> AvailableCityToVisit { get; set; }

        //public List<object> List { get => }
        public string Error { get; set; }

        public ModelCreateNewTransfer(NpgsqlConnection connection) 
        {
            this.connection = connection;
            classToGetInfo = new GetInfoAboutAvailableTransportsCities(connection);   
        }
        public int FindCountOfSeats(string transportName)
        {
            string query = $"SELECT number_of_seats FROM show_transport WHERE transport_name = '{transportName}'";
            int count = 0;
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        count = reader.GetInt32(0);
                }
            }
            return count;
        }
        public void GetInfo()
        {
            AvailableTransport = classToGetInfo.GetListOfAvailbleTransports();
            if (AvailableTransport == null)
            {
                Error = classToGetInfo.Error;
            }
            AvailableDepartureCity = classToGetInfo.GetListOfCity(true);
            if(AvailableDepartureCity == null)
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
        
        public int CreateNewTransfer(Dictionary<string, object> data)
        {
            string query = $"SELECT id_transport FROM transport WHERE transport.name = '{data["Name"]}'";
            int IDtransport = 0;
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection)) 
            {
                using(NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        IDtransport = reader.GetInt32(0);
                    }
                }
                    
            }
            string a = Convert.ToString(data["Cost"]).Replace(',', '.');

            query = $"INSERT INTO transfer VALUES(DEFAULT, {IDtransport}, '{data["fromWhere"]}', '{data["toWhere"]}', {data["CountOfSeats"]}, {a} )";
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
