using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.DirectorModels.TransportsAndTransfersModels
{
    internal class ModelShowTransports
    {
        private NpgsqlConnection connection;


        public ModelShowTransports(NpgsqlConnection connection) 
        {
            this.connection = connection;
        }

        public DataTable GetInfoAboutTransport()
        {
            DataTable transportInfo = new DataTable();
            string query = $"SELECT * FROM show_transport";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        transportInfo.Load(reader);
                }
            }

            return transportInfo;
        }

        public int DeleteTransport(int id)
        {
            string query = $"DELETE FROM transport WHERE id_transport = {id}";
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
                    return 0;
                }
                return 1;
            }
        }
    }
}
