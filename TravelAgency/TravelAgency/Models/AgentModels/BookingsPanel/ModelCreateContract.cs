using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Forms.AgentForms.OrdersPanel
{
    internal class ModelCreateContract
    {
        private NpgsqlConnection connection;
        private int ID_agent;

        public ModelCreateContract(NpgsqlConnection connection, int id_agent)
        {
            this.connection = connection;
            ID_agent = id_agent;
        }

        public DataTable GetInfo()
        {
            string query = "SELECT * FROM ShowBooking";
            DataTable dataTable = new DataTable();

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }

        public List<double> GetChangeOfPrice()
        {
            List<double> costs = new List<double>();

            return costs;
        }
    }
}
